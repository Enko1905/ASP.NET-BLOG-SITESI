using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["gonderiSil"]!=null)
            {
                dbIslemler.sqlkomut("DELETE FROM gelenler WHERE id="+Request.QueryString["gonderiSil"]);
                bildirim.BasarilitoastMesaj = "Silindi";
            }

            repeaterGelenler.DataSource = dbIslemler.GetDataTable("SELECT * FROM gelenler ORDER BY id DESC");
            repeaterGelenler.DataBind();
            
        }
    }
}