using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vueFire.Models;

namespace vueFire.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shortccttest()
        {
            return View();
        }

        public IActionResult CCTest()
        {
            return View();
        }

        public IActionResult RatedCapacity()
        {
            return View();
        }

        public IActionResult ChargeRecovery()
        {
            return View();
        }

        public IActionResult ChargeRetention()
        {
            return View();
        }

        public IActionResult Enduarance()
        {
            return View();
        }

        public IActionResult OverchargeTest()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
