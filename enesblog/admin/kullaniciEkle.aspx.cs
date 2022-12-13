using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler =new  dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["kullaniciYetki"].ToString() != "1")
                {
                    panelYetkili.Visible = false;
                    panelYetkisiz.Visible = true;
                }
                else
                {
                    panelYetkili.Visible = true;
                    panelYetkisiz.Visible = false;

                }
            }
            catch (Exception)
            {
                panelYetkili.Visible = true;
                panelYetkisiz.Visible = false;
                bildirim.BasarisiztoastMesaj = "Kullanıcı Süre Doldu";
            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string sifre, kullanciAdi,yetki;
            kullanciAdi = txtKadi.Text.ToString();
            sifre = txtSifre.Text.ToString();
            yetki = drpYetki.SelectedItem.Value;
            if(kullanciAdi != "" && sifre !="")
            {
                if(txtSifre.Text.ToString() == txtSifreTekrar.Text.ToString())
                {
                    dbIslemler.sqlkomut("insert into kullanicilar (kullaniciAd,kullaniciSifre,KullaniciAktif,kullaniciYetki) values ('" + kullanciAdi+"','"+sifre+"',1,"+yetki+")");
                    bildirim.BasarilitoastMesaj = "Kullanıcı Kayıt Edildi";
                    lblMesaj.Text = "Kullanıcı Kayıt edildi";

                }
                else
                {
                    bildirim.BasarisiztoastMesaj = "Kullanıcı Kayıt Edilemedi";
                }
            }
            else
            {
                lblMesaj.Text = "Boş Geçilemez";
            }
            Response.Redirect("kullanicilar.aspx");
        }
    }
}