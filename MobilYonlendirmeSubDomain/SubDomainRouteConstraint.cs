using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MobilYonlendirmeSubDomain
{
    public class SubDomainRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            // Burda eğer www, site, mail gibi subdomainler yazılmadı ise o route u işlet diyoruz.
            // Ve eğer IIS üzerinde subdomain altında projemiz varsa route un işaret ettiği action harekete geçiyor
            string url = httpContext.Request.Headers["HOST"];
            int index = url.IndexOf(".", System.StringComparison.Ordinal);

            if (index < 0)
            {
                return false;
            }

            string sub = url.Split('.')[0];
            if (sub == "www" || sub == "site" || sub == "mail")
            {
                return false;
            }

            //İstenilen herhangi bir parametre adı verilebilir
            values.Add("MobilParametre", sub);
            return true;
        }

    }
}