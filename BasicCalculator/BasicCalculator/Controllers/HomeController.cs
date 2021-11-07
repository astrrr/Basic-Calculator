using BasicCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message01()
        {
            string msg = "Hello, This is a test Ajax message";
            return Content(msg, "text/html", System.Text.Encoding.UTF8);
        }
        public IActionResult Message02()
        {
            string msg = "<ul><li>topic01</li><li>topic02</li><li>topic03</li><li>topic04</li><li>topic05</li></ul>";
            return Content(msg, "text/pain", System.Text.Encoding.UTF8);
        }

        public IActionResult Number3()
        {
            string num = "3";
            
            return Content(num, "text/html", System.Text.Encoding.UTF8); 
        }

        public IActionResult Number4()
        {
            string num = "4";
            ViewBag.num = num;
            return View();
        }
        public IActionResult Number5()
        {
            string num = "5";
            ViewBag.num = num;
            return View();
        }
        public IActionResult Number6()
        {
            string num = "6";
            ViewBag.num = num;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
