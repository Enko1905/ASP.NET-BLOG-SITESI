using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace enesblog
{
    public class ayarlar
    {
        Random rd = new Random();
        public string Isimuret()
        {
            int s1, s2, s3;
            string isim;

            s1 = rd.Next(9999);
            s2 = rd.Next(9999);
            s3 = rd.Next(9999);
            isim = s1 + "" + s2 + "" + s3;
            return isim;
        }
        public void dosyaSil(string isim)
        {
            if (File.Exists(HttpContext.Current.Server.MapPath(isim)))
            {
                try
                {
                    System.IO.File.Delete(HttpContext.Current.Server.MapPath(isim));
                }
                catch (Exception)
                {

                    bildirim.BasarisiztoastMesaj = "Silierken hata oluştur";
                }
            }
            else
            {
                bildirim.BasarisiztoastMesaj = "Silinecek Dosya Bulunanamadı";
            }


        }
        public void resimYuklemeMethodu(FileUpload file)
        {
            if (file.HasFile)
            {

                if (file.PostedFile.ContentType == "image/jpeg" || file.PostedFile.ContentType == "image/png")
                {
                    if (file.PostedFile.ContentLength < 4242880)
                    {
                        string filename = Path.GetFileName(file.FileName);
                        if (filename != "")
                        {

                            file.SaveAs(HttpContext.Current.Server.MapPath("../images/") + filename);

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                }
            }
        }
    }
}