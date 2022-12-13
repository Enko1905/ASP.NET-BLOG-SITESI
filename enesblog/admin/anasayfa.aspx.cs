using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Data;

namespace enesblog.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        ayarlar ar = new ayarlar();
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        DataRow dr;
        public static string buyukResimyol;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dr = dbIslemleri.getDataRow("select bannerResim,bannerBaslik,bannerMetin from siteayarlari where id=1");
                buyukResimyol = dr["bannerResim"].ToString();
                txtBannerBaslik.Text = dr["bannerBaslik"].ToString();
                txtBannerMetin.Text = dr["bannerMetin"].ToString();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            buyukResimyol = resimYukle(fileBanner, buyukResimyol);
            MySqlConnection baglanti = this.dbIslemleri.baglan();
            MySqlCommand komut = new MySqlCommand("UPDATE siteayarlari SET bannerResim = @bannerResim, bannerBaslik=@bannerBaslik,bannerMetin=@bannerMetin WHERE id =1", baglanti);
            komut.Parameters.AddWithValue("@bannerResim", buyukResimyol);
            komut.Parameters.AddWithValue("@bannerBaslik", txtBannerBaslik.Text);
            komut.Parameters.AddWithValue("@bannerMetin", txtBannerMetin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            komut.Dispose();
            bildirim.BasarilitoastMesaj = "Güncellendi";

        }
        public string resimYukle(FileUpload file, string eskiResim)
        {
            string yol = "";
            if (file.HasFile)
            {
                if (file.PostedFile.ContentLength < 4242880)
                {
                    string filename = Path.GetFileName(file.FileName);
                    if (filename != "")
                    {
                        filename = ar.Isimuret().ToString() + filename.Substring(filename.IndexOf('.'), filename.Length - filename.IndexOf('.'));
                        file.SaveAs(Server.MapPath("../images/") + filename);
                        ar.dosyaSil(eskiResim);
                        return yol = "../images/" + filename;
                    }
                }
                else
                {
                    bildirim.BasarisiztoastMesaj = "Dosya Boyutu 4 MB Altı Olmalı";
                }

            }
            return eskiResim;
        }
    }
}