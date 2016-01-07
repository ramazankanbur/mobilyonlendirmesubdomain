using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobilYonlendirmeSubDomain
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // 1. Senaryo başlangıç 
            // Sadece masaüstü sayfası olan route
        //routes.MapRoute(
        // name: "Only",
        // url: "OnlyDesktop/hoop",
        // defaults: new { controller = "Home", action = "OnlyDesktop" },
        // namespaces: new[] { "MobilYonlendirmeSubDomain.Controllers" }
        // );

        //    // Mobil için route
        //        routes.MapRoute(
        // "Mobile_Default",
        // "{controller}/{action}/{id}",
        // new { controller = "Home", action = "Index", id = UrlParameter.Optional },
        //  new { controller = new SubDomainRouteConstraint() },
        // new[] { "MobilYonlendirmeSubDomain.Areas.Mobile.Controllers" }
        // ).DataTokens.Add("Area", "Mobile");


        //    // Mobili olan route
        //      routes.MapRoute(
        // name: "Default",
        // url: "{controller}/{action}/{id}",
        // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
        // namespaces: new[] {"MobilYonlendirmeSubDomain.Controllers" }
        // );
            // 1. Senaryo bitiş





          // 2. Senaryo url hiç değişmeyecek mobilden geldiyse mobil sayfaya masaüstünden geldiyse masaüstüne yönlenecek
            routes.MapRoute(
     name: "Only",
     url: "OnlyDesktop/hoop",
     defaults: new { controller = "Home", action = "OnlyDesktop" },
     namespaces: new[] { "MobilYonlendirmeSubDomain.Controllers" }
     );


            routes.MapRoute(
     "Mobile_Default",
     "{controller}/{action}/{id}",
     new { controller = "Home", action = "Index", id = UrlParameter.Optional },
      new { controller = new SameRouteMobileConstraint() },
     new[] { "MobilYonlendirmeSubDomain.Areas.Mobile.Controllers" }
     ).DataTokens.Add("Area", "Mobile");



            routes.MapRoute(
       name: "Default",
       url: "{controller}/{action}/{id}",
       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
       namespaces: new[] { "MobilYonlendirmeSubDomain.Controllers" }
       );
            // ikinci senaryo bitiş.



        }
    }
}
