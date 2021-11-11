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
            //example data from view "123.0+456"
            //split data to *num1 *num2 *operation
            char[] opr = {' ', '+', '-', '×', '÷' };
            string[] nums;
            double val1;
            double val2;
            double newval =0;

            bool havePlus = rawResult.Contains("+");
            bool haveSecondPlus = rawResult.Contains(" ");
            bool haveSub = rawResult.Contains("-");
            bool haveDiv = rawResult.Contains("÷");
            bool haveMul = rawResult.Contains("×");
            
            Boolean checkLastOparate(string rawResult) {
                string last = rawResult.Substring(rawResult.Length-1);
                if (last == "+" | last == " " | last == "-" | last == "×" | last == "÷")
                {
                    return true;
                }
                else {
                    return false;
                }
            }

            if (checkLastOparate(rawResult))
            {
                if (rawResult.Substring(rawResult.Length - 1)==" ")
                {
                    rawResult = rawResult.Remove(rawResult.Length - 1, 1);
                    rawResult = rawResult + "+";
                    return Content(rawResult, "text/pain", System.Text.Encoding.UTF8);
                }
                else
                {
                    return Content(rawResult, "text/pain", System.Text.Encoding.UTF8);
                }
            }
            else
            {
                if (havePlus | haveSecondPlus)
                {
                    nums = rawResult.Split(opr);
                    val1 = Convert.ToDouble(nums[0]);
                    val2 = Convert.ToDouble(nums[1]);
                    newval = val1 + val2;
                }

                if (haveSub)
                {
                    nums = rawResult.Split(opr);
                    val1 = Convert.ToDouble(nums[0]);
                    val2 = Convert.ToDouble(nums[1]);
                    newval = val1 - val2;
                }

                if (haveMul)
                {
                    nums = rawResult.Split(opr);
                    val1 = Convert.ToDouble(nums[0]);
                    val2 = Convert.ToDouble(nums[1]);
                    newval = val1 * val2;
                }

                if (haveDiv)
                {
                    nums = rawResult.Split(opr);
                    val1 = Convert.ToDouble(nums[0]);
                    val2 = Convert.ToDouble(nums[1]);
                    newval = val1 / val2;
                }

                if (!havePlus && !haveSub && !haveSecondPlus && !haveMul && !haveDiv)
                {
                    newval = Convert.ToDouble(rawResult);
                }
                string temp = Convert.ToString(newval);
                return Content(temp, "text/pain", System.Text.Encoding.UTF8); 

            }
            //cast to string to sendback
            
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
