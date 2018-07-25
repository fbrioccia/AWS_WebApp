using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MVC_Core.DbClasses
{

    public class Device
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string device_id { get; set; }
        public string model { get; set; }
        public string description { get; set; }
        public ICollection<Action> actions { get; set; }
        public ICollection<Measurement> measurement { get; set; }
    }

    public class Action
    {
        public DateTime timestamp { get; set; }
        public int code { get; set; }
        public string type { get; set; }
    }

    public class Measurement
    {
        public DateTime timestamp { get; set; }
        public int temperature { get; set; }
        public int umidity { get; set; }
        public int soil_moisture { get; set; }
        public int light_level { get; set; }
    }

}