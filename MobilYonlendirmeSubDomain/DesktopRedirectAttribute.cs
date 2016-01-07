using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilYonlendirmeSubDomain
{
    public class DesktopRedirectAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var path = filterContext.HttpContext.Request.Url.AbsolutePath;
            if (!filterContext.HttpContext.Request.Browser.IsMobileDevice)
            {
                filterContext.HttpContext.Response.Redirect("http://www.site.com"+path);
            }

        }
    }
}