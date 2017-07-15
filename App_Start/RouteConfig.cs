using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GaleriUygulamasi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.MapRoute(
            //    name: "fileView",
            //    url: "Home/fileView/{id}/{dosyaAdi}",
            //    defaults: new { controller = "Home", action = "fileView", id = UrlParameter.Optional, dosyaAdi = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
