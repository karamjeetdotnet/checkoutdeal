using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CheckoutDeal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("AngularViews/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default_Admin",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CheckoutDeal.Controllers.Admin" }
            );
            //routes.MapRoute(
            //    name: "UserMapRoute",
            //    url: "{controller}/User/{action}/{id}",
            //    defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}