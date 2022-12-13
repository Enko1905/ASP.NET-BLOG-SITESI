using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class ana : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!string.IsNullOrEmpty(bildirim.BasarilitoastMesaj))
                {

                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                            "toastr.success('" + bildirim.BasarilitoastMesaj + "','Başarılı')", true);
                    bildirim.BasarilitoastMesaj = "";
                    bildirim.BasarisiztoastMesaj = "";
                }

                else if (!string.IsNullOrEmpty(bildirim.BasarisiztoastMesaj))
                {

                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                            "toastr.error('" + bildirim.BasarisiztoastMesaj + "', 'Uyarı')", true);
                    bildirim.BasarisiztoastMesaj = "";
                    bildirim.BasarilitoastMesaj = "";
                }
            }


            if (Session["kullaniciYetki"] == null)
            {
                Response.Redirect("giris.aspx");
            }



        }

        protected void btnCikisYap_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("giris.aspx");
        }
    }
}