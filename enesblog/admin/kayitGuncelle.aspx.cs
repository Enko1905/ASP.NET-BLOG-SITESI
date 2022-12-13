using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace enesblog.admin
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        ayarlar ar = new ayarlar();
        public static string buyukResimyol, kucukResimYol, icerikBaslik, icerikKisaBilgi, icerik, kategori, aktiflik;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["gnclId"] != null)
                {
                    dr = dbIslemler.getDataRow("SELECT icerikfoto.fotoKucukUrl,icerikfoto.fotoUrl,icerikler.icerikBilgi, icerikler.icerikBaslik,icerikler.icerikKisaBilgi, icerikler.icerikAktif, icerikler.icerikId, kategoriler.kategoriAd, kategoriler.kategoriRenk,kategoriler.kategoriId FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId INNER JOIN kategoriler ON icerikler.kategoriId = kategoriler.kategoriId) WHERE icerikler.icerikId=" + Request.QueryString["gnclId"]);
                    buyukResimyol = dr["fotoUrl"].ToString();
                    kucukResimYol = dr["fotoKucukUrl"].ToString();
                    icerikBaslik = dr["icerikBaslik"].ToString();
                    icerikKisaBilgi = dr["icerikKisaBilgi"].ToString();
                    icerik = dr["icerikBilgi"].ToString();
                    kategori = dr["kategoriId"].ToString();
                    aktiflik = dr["icerikAktif"].ToString();

                    txticerikBaslik.Text = icerikBaslik;
                    txticerikKisaBilgi.Text = icerikKisaBilgi;
                    txticerik.Text = icerik;



                    DataTable dt = dbIslemler.GetDataTable("SELECT kategoriId,kategoriAd FROM kategoriler");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        drpKategori.Items.Add(new ListItem(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                    }

                    drpKategori.SelectedValue = kategori;
                }
                else
                {
                    buyukResimyol = null; kucukResimYol = null; icerikBaslik = null; icerikKisaBilgi = null; icerik = null; kategori = null; aktiflik = null;
                    Response.Redirect("tumKayitlar.aspx");
                }
            }
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                icerikBaslik = txticerikBaslik.Text;
                icerikKisaBilgi = txticerikKisaBilgi.Text;
                icerik = txticerik.Text;
                kategori = drpKategori.SelectedValue;

                if (fileKucukFoto.HasFile) {kucukResimYol = resimYukle(fileKucukFoto, kucukResimYol); }
               
                if (fileBuyukFoto.HasFile) {buyukResimyol = resimYukle(fileBuyukFoto, buyukResimyol); } 

                dbIslemler.sqlkomut("UPDATE icerikFoto SET fotoKucukUrl='" + kucukResimYol + "' ,fotoUrl='" + buyukResimyol + "' ,icerikId=" + Request.QueryString["gnclId"] + " WHERE icerikId=" + Request.QueryString["gnclId"]);
                dbIslemler.sqlkomut("UPDATE icerikler SET kategoriId=" + kategori + " WHERE icerikId=" + Request.QueryString["gnclId"]);
                MySqlConnection baglanti = this.dbIslemler.baglan();

                MySqlCommand komut = new MySqlCommand("UPDATE icerikler SET icerikBaslik=@icerikBaslik,icerikBilgi=@icerikBilgi,kategoriId=@kategoriId,icerikKisaBilgi=@icerikKisaBilgi WHERE icerikId=" + Request.QueryString["gnclId"], baglanti);

                komut.Parameters.AddWithValue("@icerikBaslik", icerikBaslik);
                komut.Parameters.AddWithValue("@icerikBilgi", icerik);
                komut.Parameters.AddWithValue("@kategoriId", kategori);
                komut.Parameters.AddWithValue("@icerikKisaBilgi", icerikKisaBilgi);
                komut.ExecuteNonQuery();
                fileBuyukFoto.Dispose();
                fileKucukFoto.Dispose();
                baglanti.Close();
                baglanti.Dispose();
                komut.Dispose();
                bildirim.BasarilitoastMesaj = "Kayıt Güncellendi";
                Response.Redirect("tumKayitlar.aspx");
            }
            catch (Exception)
            {
                bildirim.BasarisiztoastMesaj = "Güncellenemedi";
                Response.Redirect("tumKayitlar.aspx");
            }

        }
        public string resimYukle(FileUpload file, string eskiResim)
        {

            if (file.HasFile)
            {
                if (file.PostedFile.ContentLength < 4242880)
                {
                    string filename = Path.GetFileName(file.FileName);
                    if (filename != "")
                    {
                        ar.dosyaSil(eskiResim);
                        filename = ar.Isimuret().ToString() + filename.Substring(filename.IndexOf('.'), filename.Length - filename.IndexOf('.'));
                        file.SaveAs(Server.MapPath("../images/") + filename);
                        return "../images/" + filename;

                    }
                }
                else
                {

                }

            }
            return eskiResim;
        }
    }
}