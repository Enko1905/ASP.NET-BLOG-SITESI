using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace enesblog
{
    public partial class ana : System.Web.UI.MasterPage
    {
        public string logoYazi, siteTitle, siteAciklama, siteEtiketler;
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                repeaterkategori.DataSource = dbIslemleri.GetDataTable("SELECT * FROM kategoriler");
                repeaterkategori.DataBind();
            }

            DataRow dr = dbIslemleri.getDataRow("SELECT logoYazi,siteTitle,siteAciklama,siteEtiketler FROM siteayarlari WHERE id=1");
            siteTitle = dr["siteTitle"].ToString();
            logoYazi = dr["logoYazi"].ToString();
            siteAciklama = dr["siteAciklama"].ToString();
            siteEtiketler = dr["siteEtiketler"].ToString();
            //Keywords için bir meta tag nesnesi oluşturalım.
            HtmlMeta Meta = new HtmlMeta();
            //Meta tag nesnesine name ve content niteliklerini ekleyelim
            Meta.Attributes.Add("name", "keywords");
            Meta.Attributes.Add("content", siteEtiketler);
            //Bu meta tagı sayfanın header listesine ekleyelim
            Page.Header.Controls.Add(Meta);

            //Description için yeni bir meta tag nesnesi oluşturalım.
            Meta = new HtmlMeta();
            //Meta tag nesnesine name ve content niteliklerini ekleyelim
            Meta.Attributes.Add("name", "description");
            Meta.Attributes.Add("content", siteAciklama);
            Page.Header.Controls.Add(Meta);

            //Sayfanın başlığını güncelle
            Page.Title = siteTitle;

            if (!Page.IsPostBack)
            {
                dbIslemleri.sqlkomut("UPDATE veriler SET girisSayisi=girisSayisi+1 WHERE id=1");
            }
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            string aranacakCumle = txtAranacakCumle.Text;
            Response.Redirect("icerik.aspx?ara=" + aranacakCumle);
        }
    }
}