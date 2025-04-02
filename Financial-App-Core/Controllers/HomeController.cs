using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Financial_App_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Transactions()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(); 

            return View(); 
        }


        public IActionResult Investments()
        {
            return View();
        }

        public IActionResult Analytics()
        {
            return View();
        }

        public IActionResult AiAssistant()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}
