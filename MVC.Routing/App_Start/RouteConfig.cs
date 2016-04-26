using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Student",
               url: "test/{studentId}/{*MoreValues}",
               defaults: new { controller = "Student", action = "Details" }
           );

            routes.MapRoute(
              name: "",
              url: "Showme/{id}",
              defaults: new { controller = "Student", action = "Index", id = "Ashish" },
              constraints: new { id = ".{4}" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}