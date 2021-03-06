﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecretSafe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Default2",
             url: "NormalSecurity/{id}",
             defaults: new { controller = "NormalSecurity", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
          name: "Default3",
          url: "MediumSecurity/{id}",
          defaults: new { controller = "MediumSecurity", action = "Index", id = UrlParameter.Optional }
      );
            routes.MapRoute(
          name: "Default4",
          url: "ProSecurity/{id}",
          defaults: new { controller = "ProSecurity", action = "Index", id = UrlParameter.Optional }
      );
            routes.MapRoute(
          name: "Default5",
          url: "MaximumSecurity/{id}",
          defaults: new { controller = "MaximumSecurity", action = "Index", id = UrlParameter.Optional }
      );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
