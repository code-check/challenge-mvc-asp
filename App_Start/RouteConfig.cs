using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace challenge_mvc_asp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //BEGIN_CHALLENGE
            routes.MapRoute(
                name: "SummerDeal",
                url: "summer-deal",
                defaults: new { controller = "Home", action = "Deal" }
            );
            //END_CHALLENGE
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
