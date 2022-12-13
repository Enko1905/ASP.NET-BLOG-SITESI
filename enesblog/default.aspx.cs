using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace enesblog
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {
 
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeatericerikler.DataSource = dbIslemler.GetDataTable("SELECT * FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId INNER JOIN kategoriler ON icerikler.kategoriId = kategoriler.kategoriId) WHERE(icerikAktif = 1) ORDER BY icerikler.icerikId DESC");
            Repeatericerikler.DataBind();

            RepeaterBanner.DataSource = dbIslemler.GetDataTable("SELECT * FROM siteayarlari");
            RepeaterBanner.DataBind();
            
        }

       
    }
}