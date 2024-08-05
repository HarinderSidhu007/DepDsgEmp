using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2_DepDsgEmp_1147
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("Home/contact");
            //routes.IgnoreRoute("Home/about");
            //routes.IgnoreRoute("Employee/{*pathInfo}");


            routes.MapRoute(
            name: "MyRoute",
            url: "cs/dotnettraining",
            defaults: new { controller = "Test", action = "abc" }
            );


            routes.MapRoute(
           name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

                routes.MapRoute(
                name: "movieroute",
                url: "Movie/ReleaseDate/{year}/{month}",
                defaults: new { controller = "movie", action = "DateOfMovie" },
                constraints: new { month = @"\d{2}", year = @"\d{4}" }
            );
        }
    }
}
