using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public static string kullaniciAd, eskiSifre, yeniSifre, yeniSifreTekrar, yetki;
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
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
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["gnclId"] != null)
                {
                    DataRow dr = dbIslemler.getDataRow("SELECT * FROM kullanicilar WHERE kullaniciId=" + Request.QueryString["gnclId"]);
                    kullaniciAd = dr["kullaniciAd"].ToString();
                    yetki = dr["kullaniciYetki"].ToString();
                    eskiSifre = dr["kullaniciSifre"].ToString();
                    txtKadi.Text = kullaniciAd;
                    drpYetki.SelectedValue = yetki;


                }
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            kullaniciAd = txtKadi.Text;
            yeniSifre = txtSifre.Text;
            yetki = drpYetki.SelectedValue.ToString();

            if (txtEskiSifre.Text == eskiSifre)
            {
                if (txtSifre.Text==txtSifreTekrar.Text)
                {
                    dbIslemler.sqlkomut("UPDATE kullanicilar SET kullaniciAd='"+kullaniciAd+ "',kullaniciSifre='"+yeniSifre+ "', kullaniciYetki='"+yetki+ "' WHERE kullaniciId= " + Request.QueryString["gnclId"]);
                    bildirim.BasarilitoastMesaj = "Kullanıcı Güncelledi";
                }
                else
                {
                    lblMesaj.Text = "Şifre Aynı Olmalı";
                }
                
            }
            else
            {
                lblMesaj.Text = "Eski Şifre Yanlış";
            }
        }
    }
}