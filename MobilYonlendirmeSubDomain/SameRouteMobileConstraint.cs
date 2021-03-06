﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MobilYonlendirmeSubDomain
{
    public class SameRouteMobileConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {

            if (!httpContext.Request.Browser.IsMobileDevice)
            {
                return false;
            }
            return true;
        }
    }
}