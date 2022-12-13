using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace enesblog
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMesaj.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string adSoyad, konu, email, mesaj, tarih;
            adSoyad = txtAdSoyad.Text.ToString();
            email = txtEmail.Text.ToString();
            konu = txtKonu.Text.ToString();
            mesaj = txtMesaj.Text.ToString();
            tarih = DateTime.Now.ToLongDateString().ToString();
            try
            {


                if (adSoyad != "" && konu != "" && email != "" && mesaj != "")
                {


                    MySqlConnection baglanti = this.dbIslemler.baglan();

                    MySqlCommand komut = new MySqlCommand("insert into gelenler (gonderenAd,gonderenEmail,konu,mesaj,tarih) values (@gonderenAdi ,@gonderenEmail,@konu ,@mesaj,@tarih )", baglanti);

                    komut.Parameters.AddWithValue("@gonderenAdi", adSoyad);
                    komut.Parameters.AddWithValue("@gonderenEmail", email);
                    komut.Parameters.AddWithValue("@konu", konu);
                    komut.Parameters.AddWithValue("@mesaj", mesaj);
                    komut.Parameters.AddWithValue("@tarih", tarih);
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                    baglanti.Dispose();
                    komut.Dispose();
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "EPOSTA GÖNDERİLDİ";
                }
                else
                {
                    lblMesaj.Text = "BOŞ GEÇİLMEZ";
                }
            }
            catch (Exception)
            {

                lblMesaj.Text = "Hata Oluştu";
            }
        }
    }
}