using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bai_3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //http://domain-name/Danh-Sach-Bai-Hat
            routes.MapRoute(
            name: "Show Music",
            url: "Danh-Sach-Bai-Hat",
            defaults: new
            {
                controller = "Music",
                action = "Index"
            }
            );

            //http://domain-name/Danh-Sach-Bai-Hat/MusicName
            routes.MapRoute(
            name: "Listen Music",
            url: "Danh-Sach-Bai-Hat/{musicName}",
            defaults: new
            {
                controller = "Music",
                action = "Listen",
            }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Music",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
