using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        public static string renkBaslik { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlcumle = "SELECT * FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId) WHERE(icerikAktif = 1) LIMIT 1";

            if (Request.QueryString["kId"] != null)
            {
                sqlcumle = "SELECT * FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId) WHERE(icerikAktif = 1 AND kategoriId=" + Request.QueryString["kId"]+ ") ORDER BY icerikler.icerikId DESC";
                DataRow baslik = dbIslemler.getDataRow("select kategoriAd,kategoriRenk from kategoriler WHERE kategoriId="+ Request.QueryString["kId"]);
                renkBaslik = baslik["kategoriRenk"].ToString();
                lblAranan.Text = baslik["kategoriAd"].ToString().ToUpper();
            }
            else if (Request.QueryString["icId"] != null)
            {

                string icerikSqlcumle = "SELECT * FROM icerikler  WHERE icerikAktif = 1 AND icerikId=" + Request.QueryString["icId"];
           
                panelIcerikler.Visible = false;
                panelIcerkBilgi.Visible = true;
                repeaterTekIcerik.DataSource = dbIslemler.GetDataTable(icerikSqlcumle);
                repeaterTekIcerik.DataBind();

            }
            else if (Request.QueryString["ara"] != null)
            {
                sqlcumle = "SELECT * FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId) WHERE(icerikAktif = 1 AND (icerikBaslik LIKE '%" + Request.QueryString["ara"] + "%' OR icerikBilgi LIKE  '%" + Request.QueryString["ara"] + "%'))";
                lblAranan.Text = "' " + Request.QueryString["ara"].ToLower() + " ' İle ilgili Sonuçlar";
                
            }
            else
            {
                sqlcumle = "SELECT * FROM(icerikler INNER JOIN icerikfoto ON icerikler.icerikId = icerikfoto.icerikId) WHERE(icerikAktif = 1)  ORDER BY icerikler.icerikId DESC";
            }
            Repeatericerik.DataSource = dbIslemler.GetDataTable(sqlcumle);
            Repeatericerik.DataBind();

            


        }
        public string icerikFotoGetir(int icerikId)
        {

            return  dbIslemler.getDataCell("SELECT fotoUrl FROM icerikfoto WHERE icerikId = " + icerikId);
           
        }
        public string kucukFotoGetir(int icerikId)
        {

            return dbIslemler.getDataCell("SELECT fotoKucukUrl FROM icerikfoto WHERE icerikId = " + icerikId);
           
        }
    }
}