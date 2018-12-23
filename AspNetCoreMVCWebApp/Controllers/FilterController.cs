using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreMVCWebApp.Controllers
{
    public class FilterController : Controller
    {
        protected DateTime StartTime;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.ActionDescriptor.RouteValues["action"];
            if(string.Equals(action , "index", StringComparison.CurrentCultureIgnoreCase))
            {
                StartTime = DateTime.Now;
            }
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var action = context.ActionDescriptor.RouteValues["action"];
            if (string.Equals(action, "index", StringComparison.CurrentCultureIgnoreCase))
            {
                var timeSpan = DateTime.Now - StartTime;
                context.HttpContext.Response.Headers.Add("duration", timeSpan.TotalMilliseconds.ToString());
            }
            base.OnActionExecuted(context);
        }

        public IActionResult Index()
        {
            return Ok("Just processed Filter.Index");
        }
    }
}