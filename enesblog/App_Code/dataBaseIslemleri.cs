using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace enesblog
{
    public class dataBaseIslemleri
    {

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mysqlConnect"].ConnectionString);
            baglanti.Open();
            return baglanti;
        }
        public int sqlkomut(string sqlCumle)
        {
            MySqlConnection baglanti = this.baglan();
            MySqlCommand sorgu = new MySqlCommand(sqlCumle, baglanti);
            int sonuc = 0;
            sonuc = sorgu.ExecuteNonQuery();
            sorgu.Dispose();
            baglanti.Close();
            baglanti.Dispose();
            return sonuc;
        }
        public DataTable GetDataTable(string sqlCumle)
        {

            MySqlConnection baglanti = this.baglan();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCumle, baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            baglanti.Close();
            baglanti.Dispose();
            return dt;

        }
        public DataRow getDataRow(string sqlCumle)
        {
            DataTable dt = this.GetDataTable(sqlCumle);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt.Rows[0];

            }

        }

        public string getDataCell(string sqlCumle)
        {
            try
            {
                DataRow dr = this.getDataRow(sqlCumle);
                string hucre = dr[0].ToString();
                return hucre;
            }
            catch (Exception exept)
            {
                return null;
            }

        }
    }
}