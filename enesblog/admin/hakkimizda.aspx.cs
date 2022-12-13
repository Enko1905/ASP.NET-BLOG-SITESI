using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace enesblog.admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtHakkimizda.Text = dbIslemleri.getDataCell("select hakkimizda from siteayarlari where id=1");
            }
          
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                string cumle = txtHakkimizda.Text.ToString();


                MySqlConnection baglanti = this.dbIslemleri.baglan();

                MySqlCommand komut = new MySqlCommand("UPDATE siteayarlari SET hakkimizda=@hakkimizda WHERE id =1 ", baglanti);

                komut.Parameters.AddWithValue("@hakkimizda", cumle);


                komut.ExecuteNonQuery();

                baglanti.Close();
                baglanti.Dispose();
                komut.Dispose();

                lblMesaj.Text = "Kayıt Başarılı";
                bildirim.BasarilitoastMesaj = "Güncellendi";
            }
            catch (Exception)
            {

                lblMesaj.Text = "Kayıt Başarısız";
                bildirim.BasarisiztoastMesaj = "Güncellenemedi";
            }
          
           
        }
    }
}