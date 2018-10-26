using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MVC_Core.Iot
{
    public static class IotClient
    {
        private static MqttClient _instance;
        private static string response = String.Empty;

        public static MqttClient Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                Console.WriteLine("Mqtt Singleton client null -> Implementing..");
                string iotendpoint = "IOT_END_POINT";
                int BrokerPort = 8883;
                string[] subscribeTopics = new string[] { "A_1", "A_2" };

                var assembly = System.Reflection.Assembly.GetEntryAssembly();

                string[] names = assembly.GetManifestResourceNames();
                foreach (var n in names)
                    Console.WriteLine("**" + n);
                var rootCAStream = assembly.GetManifestResourceStream("MVC_Core.root-CA.crt");
                byte[] rootCABinary;
                using (BinaryReader br = new BinaryReader(rootCAStream))
                {
                    rootCABinary = br.ReadBytes((int)rootCAStream.Length);
                }

                var CaCert = new X509Certificate(rootCABinary);

                var clientCertStream = assembly.GetManifestResourceStream("MVC_Core.dotnet_devicecertificate.pfx");
                if (clientCertStream == null)
                    Console.WriteLine("PFX Not Found!");

                byte[] clientCertBinary;
                using (BinaryReader br = new BinaryReader(clientCertStream))
                {
                    clientCertBinary = br.ReadBytes((int)clientCertStream.Length);
                }
                var ClientCert = new X509Certificate2(clientCertBinary, "password");

                var emptyMessage = String.Empty;
                string ClientId = Guid.NewGuid().ToString();

                _instance = new MqttClient(iotendpoint, BrokerPort, true, CaCert, ClientCert, MqttSslProtocols.TLSv1_2);

                _instance.MqttMsgSubscribed += IotClient_MqttMsgSubscribed;
                _instance.MqttMsgPublishReceived += IotClient_MqttMsgPublishReceived;


                _instance.Connect(ClientId);
                Console.WriteLine("Connected");

                _instance.Subscribe(subscribeTopics, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });


                return _instance;
            }
        }

        //Metodo di test
        public static RootObject GetShadow(string deviceThingName)
        {
            string topic = "";
            response = null;
            Instance.Publish(topic, Encoding.UTF8.GetBytes(""));
            response = null;
            while (response == null) ;
            return SerializeJson(response);
        }

        public static string GetShadowRaw(string deviceThingName)
        {
            Console.WriteLine("Entered Method GetShadowRaw ");
            string topic = "$aws/things/esp8266_AB006E/shadow/get";
            response = null;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Instance.Publish(topic, Encoding.UTF8.GetBytes(""));
            Console.WriteLine("Empty messege published on " + topic);
            response = null;
            while (response == null && watch.ElapsedMilliseconds <= 14000)
                Console.Write('+');

            Console.WriteLine("Returning resoponse Method GetShadowRaw exit");
            return response;
        }

        public static bool UpdateShadowRaw(string deviceThingName, string[] jsonContent)
        {
            try
            {

                string topic = "$aws/things/esp8266_AB006E/shadow/update";


                string messageContent =
                @"{
                    ""state"": {
                        ""desired"": {
                            " + string.Join(",", jsonContent)
                            + @"}
                    }
                }";

                //var watch = System.Diagnostics.Stopwatch.StartNew();
                Instance.Publish(topic, Encoding.UTF8.GetBytes(messageContent));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }

        private static RootObject SerializeJson(String jsonText)
        {
            if (String.IsNullOrEmpty(jsonText))
                return new RootObject();
            //string jsonText = File.ReadAllText(@"C:\Users\fabri\Source\Repos\AWS_IOT_REST\AWS_IOT_REST\sample.txt");
            MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(jsonText));
            StreamReader reader = new StreamReader(mStrm);

            JsonSerializer serializer = new JsonSerializer();
            RootObject rootObj = (RootObject)serializer.Deserialize(reader, typeof(RootObject));
            //string json = JsonConvert.SerializeObject(movie2, Formatting.Indented);

            return rootObj;
        }

        private static void IotClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {

                response = (System.Text.Encoding.UTF8.GetString(e.Message));
                Console.WriteLine("Message recived" + response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private static void IotClient_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            Console.WriteLine("Subscribed to the AWS IOT MQTT topic  ");
        }

    }
}
