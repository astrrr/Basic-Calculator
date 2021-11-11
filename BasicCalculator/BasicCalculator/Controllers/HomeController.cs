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

        public IActionResult Operate(string rawResult)
        {
            //example data from view "123+456"
            //split data to *num1 *num2 *operation
            char[] opr = {' ', '+', '-', '×', '÷' };
            string[] nums = rawResult.Split(opr);

            bool havePlus = rawResult.Contains("+");
            bool haveSecondPlus = rawResult.Contains(" ");
            bool haveSub = rawResult.Contains("-");
            bool haveDiv = rawResult.Contains("÷");
            bool haveMul = rawResult.Contains("×");
            
            //

            uint val1 = Convert.ToUInt32(nums[0]);
            uint val2 = Convert.ToUInt32(nums[1]);

            uint newval =0;

            if (havePlus|haveSecondPlus) {
                newval =val1 + val2;
            }

            if (haveSub)
            {
                newval = val1 - val2;
            }

            if (haveMul)
            {
                newval = val1 * val2;
            }

            if (haveDiv)
            {
                newval = val1 / val2;
            }

            //cast to string to sendback
            string temp = Convert.ToString(newval);
            return Content(temp, "text/pain", System.Text.Encoding.UTF8); 
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
