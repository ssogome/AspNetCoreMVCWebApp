using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVCWebApp.Models;
using AspNetCoreMVCWebApp.Helpers;

namespace AspNetCoreMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        [AjaxOnly]
        [Header(Name ="Action", Value ="About")]
        public IActionResult Index()
        {           
            return new ContentResult { Content = "Home.Index" };
        }
        public IActionResult Email([Bind(Prefix ="email")] IList<string> emails)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
