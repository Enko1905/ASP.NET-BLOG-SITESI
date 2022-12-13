using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["kategoriSilId"] != null)
            {
                dbIslemler.sqlkomut("DELETE FROM kategoriler WHERE kategoriId=" + Request.QueryString["kategoriSilId"]);
                bildirim.BasarilitoastMesaj = "Silindi";
                Response.Redirect("kategoriler.aspx");
                
            }
            repeaterKategoriler.DataSource = dbIslemler.GetDataTable("SELECT * FROM kategoriler");
            repeaterKategoriler.DataBind();
        }
    }
}