using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            string bilgi = dbIslemleri.getDataCell("SELECT hakkimizda FROM siteayarlari");
            pyaz.InnerHtml = bilgi;
           
            
        }
    }
}