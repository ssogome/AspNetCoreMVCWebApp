using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCWebApp.Helpers
{
    public class HeaderAttribute: ActionFilterAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override void OnActionExecuted(ActionExecutedContext ctxt)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Value)) ctxt.HttpContext.Response.Headers.Add(Name, Value);

            return;
        }
    }
}
