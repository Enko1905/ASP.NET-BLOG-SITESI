using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemler = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception)
            {
                panelYetkili.Visible = true;
                panelYetkisiz.Visible = false;
                bildirim.BasarisiztoastMesaj = "Kullanıcı Süre Doldu";
                
            }
            if (Request.QueryString["kullaniciAktifId"] != null && Request.QueryString["aktif"] != null)
            {
                if (Request.QueryString["aktif"] == "1")
                {
                    dbIslemler.sqlkomut("UPDATE kullanicilar SET kullaniciAktif = 0 WHERE kullaniciId=" + Request.QueryString["kullaniciAktifId"]);
                }
                else
                {
                    dbIslemler.sqlkomut("UPDATE kullanicilar SET kullaniciAktif =1 WHERE kullaniciId=" + Request.QueryString["kullaniciAktifId"]);

                }
                Response.Redirect("kullanicilar.aspx");
            }
            else if (Request.QueryString["kullaniciSilId"] != null)
            {
                dbIslemler.sqlkomut("DELETE FROM kullanicilar WHERE kullaniciId=" + Request.QueryString["kullaniciSilId"]);
                Response.Redirect("kullanicilar.aspx");
            }
            repeaterTumKullanicilar.DataSource = dbIslemler.GetDataTable("SELECT * FROM kullanicilar");
            repeaterTumKullanicilar.DataBind();

        }
    }
}