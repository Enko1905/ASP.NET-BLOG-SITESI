using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enesblog.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        dataBaseIslemleri dbIslemleri = new dataBaseIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataRow drA = dbIslemleri.getDataRow("SELECT count(*) as aktif FROM icerikler WHERE icerikAktif=1");
                DataRow drB = dbIslemleri.getDataRow("SELECT count(*) as pasif FROM icerikler WHERE icerikAktif=0");
                DataRow drC = dbIslemleri.getDataRow("SELECT count(*) as icerik FROM icerikler");
                DataRow drD = dbIslemleri.getDataRow("SELECT girisSayisi FROM veriler");

                lblAktifIcerik.Text = drA["aktif"].ToString();
                lblPasifIcerikler.Text = drB["pasif"].ToString();
                lblIcerik.Text = drC["icerik"].ToString();
                lblGoruntulenme.Text = drD["girisSayisi"].ToString();
            }

        }
    }
}