using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string kategoriAd, kategoriRenk;
            kategoriAd = txtKategoriAd.Text.ToString();
            kategoriRenk = txtKategoriRenk.Text.ToString();
            if (kategoriAd != "" && kategoriRenk != "")
            {
                dbIslemler.sqlkomut("insert into kategoriler (kategoriAd,kategoriRenk) values ('" + kategoriAd + "','" + kategoriRenk + "')");
                bildirim.BasarilitoastMesaj = "Kategori Eklendi";
                Response.Redirect("kategoriler.aspx");

            }
            else
            {
                lblMesaj.Text = "Boş Geçilmez";
            }
        }
    }
}