using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        public static string logoAdi, siteTitle, siteAciklama, siteEtiketler;
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataRow dr = dbIslemler.getDataRow("SELECT * FROM siteayarlari WHERE id=1");
                logoAdi = dr["logoYazi"].ToString();
                siteTitle = dr["siteTitle"].ToString();
                siteAciklama = dr["siteAciklama"].ToString();
                siteEtiketler = dr["siteEtiketler"].ToString();

                txtLogo.Text = logoAdi;
                txtTitle.Text = siteTitle;
                txtAciklamalar.Text = siteAciklama;
                txtEtiketler.Text = siteEtiketler;

            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            logoAdi = txtLogo.Text;
            siteTitle = txtTitle.Text;
            siteAciklama = txtAciklamalar.Text;
            siteEtiketler = txtEtiketler.Text;
            dbIslemler.sqlkomut("UPDATE siteayarlari SET logoYazi='" + logoAdi + "',siteTitle='" + siteTitle + "',siteAciklama='" + siteAciklama + "',siteEtiketler='" + siteEtiketler + "'  WHERE id=1");
            bildirim.BasarilitoastMesaj = "Ayarlar Güncellenedi";
            lblMesaj.Text = "Kayıt Başarılı";
            Response.Redirect("siteAyarlari.aspx");
            
        }
    }
}