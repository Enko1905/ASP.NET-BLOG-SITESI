using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm6 : System.Web.UI.Page
    {
      
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        ayarlar ar = new ayarlar();
        string icerikBaslik, icerikKisaBilgi, icerik, kucukFotoUrl = "", BuyukFotoUrl = "", kategori;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = dbIslemleri.GetDataTable("SELECT kategoriAd,kategoriId FROM kategoriler");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    drpKategori.Items.Add(new ListItem(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString()));
                }
            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                icerikBaslik = txtBaslik.Text.ToString();
                icerikKisaBilgi = txtKisaBilgi.Text.ToString();
                icerik = txticerik.Text.ToString();
                kategori = drpKategori.SelectedValue;


                if (icerikBaslik != "" && icerikKisaBilgi != "" && icerik != "" && kategori != "")
                {
                    // dbIslemleri.sqlkomut("insert into icerikler (icerikBaslik,icerikBilgi,icerikAktif,kategoriId,icerikKisaBilgi)  values ('" + icerikBaslik + "','" + icerik + "',1," + kategori + ",'" + icerikKisaBilgi + "')");

                    MySqlConnection baglanti;
                    baglanti = this.dbIslemleri.baglan();

                    MySqlCommand komut;
                    komut = new MySqlCommand("insert into icerikler (icerikBaslik,icerikBilgi,icerikAktif,kategoriId,icerikKisaBilgi)  values (@icerikBaslik,@icerikBilgi,@aktif,@kategoriId,@icerikKisaBilgi)", baglanti);

                    komut.Parameters.AddWithValue("@icerikBaslik", icerikBaslik);
                    komut.Parameters.AddWithValue("@icerikBilgi", icerik);
                    komut.Parameters.AddWithValue("@aktif", 1);
                    komut.Parameters.AddWithValue("@kategoriId", kategori);
                    komut.Parameters.AddWithValue("@icerikKisaBilgi", icerikKisaBilgi);
                    komut.ExecuteNonQuery();

                    komut.Dispose();
                    baglanti.Close();
                    baglanti.Dispose();

                    BuyukFotoUrl = resimYukle(fileBuyukResim);
                    kucukFotoUrl = resimYukle(fileKucukResim);
                    
                    dbIslemleri.sqlkomut("insert into icerikfoto (fotoUrl,fotoKucukUrl,icerikId)  values ('" + BuyukFotoUrl + "','" + kucukFotoUrl + "', (SELECT LAST_INSERT_ID() from icerikler LIMIT 1))");
                    fileBuyukResim.Dispose();
                    fileKucukResim.Dispose();
                    bildirim.BasarilitoastMesaj = "İçerik Kayıt Edildi";
                    Response.Redirect("tumKayitlar.aspx");
                   



                }
                else
                {
                    lblMesaj.Text = "Boş Geçilmez";
                }
            }
            catch (Exception ex)
            {

                lblMesaj.Text = "Hata Oluştu";
                bildirim.BasarisiztoastMesaj = "Kayıt Edilemedi" + kucukFotoUrl + "," + BuyukFotoUrl + "";

            }
        }
        public string resimYukle(FileUpload file)
        {
            string filename;
            if (file.HasFile)
            {
                if (file.PostedFile.ContentLength < 1024*1024*4)
                {
                    filename = Path.GetFileName(file.FileName);
                    if (filename != "")
                    {
                        filename = ar.Isimuret().ToString() + filename.Substring(filename.IndexOf('.'), filename.Length - filename.IndexOf('.'));
                        file.SaveAs(Server.MapPath("../images/") + filename);
                        file.Dispose();
                        return "../images/" + filename;

                    }
                }
                else
                {
                    bildirim.BasarisiztoastMesaj = "Dosya Boyutu 4 MB altında Olmalı";
                }
            }

            return null;
        }

        
    }


}