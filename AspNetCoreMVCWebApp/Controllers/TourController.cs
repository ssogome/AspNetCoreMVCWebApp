using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCWebApp.Controllers
{
    [Route("goto/{city}")]
    public class TourController : Controller
    {
        [Route("/[controller]/[action]")]
        [ActionName("ny")]
        public IActionResult NewYork()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        [Route("chicago")]
        public IActionResult Chicago()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        public IActionResult LosAngeles()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        [Route("nyc")]
        public IActionResult NewYorkCity()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        [Route("/ny")]
        public IActionResult BigApple()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}