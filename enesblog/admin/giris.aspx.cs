using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class giris : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMesaj.Visible = false;   
            if (Session["kullaniciYetki"] != null)
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            
            string kullaniciad, sifre;
            kullaniciad = txtKullaniciAdi.Text.ToString();
            sifre = txtSifre.Text.ToString();
            DataRow dr = dbIslemler.getDataRow("SELECT kullaniciAd,kullaniciSifre,kullaniciYetki FROM kullanicilar WHERE kullaniciAd='" + kullaniciad + "' AND kullaniciSifre='"+sifre+"' AND kullaniciAktif=1");
            
            if(dr != null)
            {

                Session["kullaniciYetki"] = dr["kullaniciYetki"].ToString();
                Session.Timeout=15;
                bildirim.BasarilitoastMesaj = "Giriş Yapıldı";
                Response.Redirect("default.aspx");

                lblMesaj.Visible = false;

            }
            else
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Kullanıcı Bulunamadı";
            }
        }
    }
}