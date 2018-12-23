using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCWebApp.Controllers
{
    [Route("/go/to/[action]")]
    public class VipTourController : Controller
    {
        public IActionResult NewYork()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        public IActionResult Chicago()
        {
            var action = RouteData.Values["action"].ToString();
            return Ok(action);
        }

        [Route("{days:int}/days")]
        //[ActionName("San Francisco")]
        public IActionResult SanFrancisco(int days)
        {
            //Capture data in manual way from the query string
            var data = RouteData.Values["days"];

            var action = string.Format("In {0} for {1} days. Controller={2} and parameter in query is:{3}", RouteData.Values["action"].ToString(), days, RouteData.Values["controller"].ToString(), data);
     
            return Ok(action);
        }
    }
}