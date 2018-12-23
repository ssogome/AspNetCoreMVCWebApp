using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCWebApp.Helpers
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =false)]
    public class CultureAttribute: ActionFilterAttribute
    {
        public string Name { get; set; }
        public static string CookieName
        {
            get { return "_Culture"; }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var culture = Name;
            if (string.IsNullOrEmpty(culture)) culture = GetSavedCultureOrDefault(context.HttpContext.Request);

            //Set  culture on current thread
            SetCultureOnThread(culture);

            //Proceed as usual
            base.OnActionExecuting(context);
        }

        private static string GetSavedCultureOrDefault(HttpRequest httpRequest)
        {
            var culture = CultureInfo.CurrentCulture.Name;
            var cookie = httpRequest.Cookies[CookieName] ?? culture;

            return cookie;
        }

        private static void SetCultureOnThread(string language)
        {
            var cultureInfo = new CultureInfo(language);
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }
    }
}
