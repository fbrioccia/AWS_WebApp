using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core.DbClasses;
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

            var deviceContext = new DeviceContext();
            var dev = deviceContext.GetDevices();
            return View(dev);
        }

        public IActionResult Data()
        {
            return View();
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
