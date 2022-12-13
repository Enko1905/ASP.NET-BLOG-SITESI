using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace enesblog.admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        dataBaseIslemleri dataBaseIslemleri = new dataBaseIslemleri();
        ayarlar ar = new ayarlar();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["kayitId"] !=null && Request.QueryString["islem"]=="sil")
            {
                DataRow dr = dataBaseIslemleri.getDataRow("SELECT fotoKucukUrl,fotoUrl FROM icerikFoto WHERE icerikId=" + Request.QueryString["kayitId"]);
                ar.dosyaSil(dr["fotoKucukUrl"].ToString());
                ar.dosyaSil(dr["fotoUrl"].ToString());
                dataBaseIslemleri.sqlkomut("DELETE FROM icerikFoto WHERE icerikId=" + Request.QueryString["kayitId"]);
                dataBaseIslemleri.sqlkomut("DELETE FROM icerikler WHERE icerikId="+ Request.QueryString["kayitId"]);
                
                bildirim.BasarilitoastMesaj = "Silindi";
                Response.Redirect("tumKayitlar.aspx");
            }
            if (Request.QueryString["icerkAktifId"] != null && Request.QueryString["aktif"] != null)
            {
                if (Request.QueryString["aktif"] == "1")
                {
                    dataBaseIslemleri.sqlkomut("UPDATE icerikler SET icerikAktif = 0 WHERE icerikid=" + Request.QueryString["icerkAktifId"]);
                }
                else
                {
                    dataBaseIslemleri.sqlkomut("UPDATE icerikler SET icerikAktif =1 WHERE icerikid=" + Request.QueryString["icerkAktifId"]);

                }
                Response.Redirect("tumKayitlar.aspx");
            }


            repeaterTumIcerikler.DataSource =  dataBaseIslemleri.GetDataTable("SELECT icerikfoto.fotoKucukUrl,icerikfoto.fotoUrl, icerikler.icerikBaslik, icerikler.icerikAktif, icerikler.icerikId, kategoriler.kategoriAd, kategoriler.kategoriRenk FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId INNER JOIN kategoriler ON icerikler.kategoriId = kategoriler.kategoriId) ORDER BY icerikler.icerikId DESC");
            repeaterTumIcerikler.DataBind();
      
            
        }

        public string aktiflik(int deger)
        {
            if (deger == 1)
            {
                return "Aktif";

            }
            else
            {
                return "Pasif";
            }
        }
    }
   

    
}