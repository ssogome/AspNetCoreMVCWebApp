using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCWebApp.Controllers
{
    public class BindingController : Controller
    {
        //[Route("moveto/{city}")]
      public IActionResult Visit([FromQuery] string city)
        {
            return Ok(city);
        }

        public IActionResult Repeat(string text, int number)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < number; i++)
            {
                builder.AppendFormat("{0}, ", text);
            }
            return Ok(builder.ToString());
        }

        public IActionResult Accept([FromHeader(Name = "Accept-Language")] string language)
        {
            return Ok(language);
        }
    }
}