using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace enesblog
{
    public class RouteConfig
    {
        public static void RegisterUrl(RouteCollection UrlRoute)
        {
            UrlRoute.MapPageRoute("AnaSayfa", "AnaSayfa", "~/default.aspx");
            UrlRoute.MapPageRoute("Hakkimizda", "Hakkimizda", "~/hakkimizda.aspx");
            UrlRoute.MapPageRoute("Iletisim", "Iletisim", "~/iletisim.aspx");
            UrlRoute.MapPageRoute("icerikler", "icerikler-{Baslik}", "~/icerik.aspx");
            UrlRoute.MapPageRoute("icerikKategorş", "icerik-kategori-{kategori}", "~/icerik.aspx");




        }
    }
}