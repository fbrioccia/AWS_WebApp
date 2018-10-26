using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core.Data;
using MVC_Core.DbClasses;
using MVC_Core.Iot;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        public IActionResult Device()
        {
            try
            {

                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetDevices();
                return View(dev);
            }
            catch (Exception ex)
            {
                Console.WriteLine("IActionResult Device " + ex.Message);
            }

            return View();

        }

        public IActionResult Data()
        {
            try
            {
                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetDevices();

                List<DataPoint> dataPoints = new List<DataPoint>{
                new DataPoint(DateTime.Now, 50),
                new DataPoint(DateTime.Now, 70),
                new DataPoint(DateTime.Now,30 ),
                new DataPoint(DateTime.Now,50 ),
                new DataPoint(DateTime.Now,40),
            };

                ViewBag.DataPoints = Newtonsoft.Json.JsonConvert.SerializeObject(dataPoints);


                return View(dev);
            }
            catch (Exception ex)
            {
                Console.WriteLine("IActionResult Data " + ex.Message);
            }

            return View();
        }

        public JsonResult GetSoilMoisture(string deviceId, string fromDate, string toDate)
        {
            try
            {
                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetMeasurementByDates(deviceId, fromDate, toDate);
                //var dataPoints = new List<DataPoint>();
                //dev.ForEach(mes => dataPoints.Add(new DataPoint(mes.timestamp, (double)mes.soil_moisture)));
                return Json(dev.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult GetSoilMoisture " + ex.Message);
            }

            return Json("");
        }

        public JsonResult GetHumidity(string deviceId, string fromDate, string toDate)
        {
            try
            {
                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetMeasurementByDates(deviceId, fromDate, toDate);
                //var dataPoints = new List<DataPoint>();
                //dev.ForEach(mes => dataPoints.Add(new DataPoint(mes.timestamp, (double)mes.humidity)));
                return Json(dev.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult GetHumidity " + ex.Message);
            }

            return Json("");
        }

        public JsonResult GetTemperature(string deviceId, string fromDate, string toDate)
        {
            try
            {
                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetMeasurementByDates(deviceId, fromDate, toDate);
                //var dataPoints = new List<DataPoint>();
                //dev.ForEach(mes => dataPoints.Add(new DataPoint(mes.timestamp, (double)mes.temperature)));
                return Json(dev.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult GetTemperature " + ex.Message);
            }

            return Json("");
        }

        public JsonResult GetLightLevels(string deviceId, string fromDate, string toDate)
        {
            try
            {
                var deviceContext = new DeviceContext();
                var dev = deviceContext.GetMeasurementByDates(deviceId, fromDate, toDate);
                //var dataPoints = new List<DataPoint>();
                //dev.ForEach(mes => dataPoints.Add(new DataPoint(mes.timestamp, (double)mes.light_level)));
                return Json(dev.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult GetTemperature " + ex.Message);
            }

            return Json("");
        }

        public JsonResult GetShadow(string deviceId)
        {
             try
            {
                var deviceShadow = IotClient.GetShadowRaw(deviceId);
                return Json(deviceShadow);
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult GetShadow " + ex);
            }

            return Json("");
        }

        public JsonResult UpdateShadow(string deviceId, string[] jsonContent)
        {
            
             try
            {
                var deviceShadow = IotClient.UpdateShadowRaw(deviceId, jsonContent);
                return Json(deviceShadow);
            }
            catch (Exception ex)
            {
                Console.WriteLine("JsonResult UpdateShadow " + ex);
            }

            return Json("");
        } 

        public IActionResult Settings()
        {
            
            return View();
        }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
