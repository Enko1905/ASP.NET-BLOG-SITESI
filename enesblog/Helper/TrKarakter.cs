using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enesblog
{
    public class TrKarakter
    {
        public static string TurKarakter(string metin)
        {
            metin = metin.ToLower();
            return metin.Replace("<", "").
                       Replace(">", "").
                       Replace("é", "").
                       Replace("!", "").
                       Replace("'", "").
                       Replace("£", "").
                       Replace("^", "").
                       Replace("#", "").
                       Replace("$", "").
                       Replace("+", "").
                       Replace("%", "").
                       Replace("½", "").
                       Replace("&", "").
                       Replace("\"", "").
                       Replace("{", "").
                       Replace("(", "").
                       Replace("[", "").
                       Replace(")", "").
                       Replace("]", "").
                       Replace("}", "").
                       Replace("?", "").
                       Replace("*", "").
                       Replace("@", "").
                       Replace("€", "").
                       Replace("~", "").
                       Replace("æ", "").
                       Replace("ß", "").
                       Replace(".", "").
                       Replace(",", "").
                       Replace("`", "").
                       Replace("|", "").
                       Replace(" ", "-").
                       Replace(":", "").
                       Replace("İ", "i").
                       Replace("I", "i").
                       Replace("ı", "i").
                       Replace("ğ", "g").
                       Replace("Ğ", "g").
                       Replace("ü", "u").
                       Replace("Ü", "u").
                       Replace("ş", "s").
                       Replace("Ş", "s").
                       Replace("ö", "o").
                       Replace("Ö", "o").
                       Replace("ç", "c").
                       Replace("Ç", "c").
                       Replace("--", "-").
                       Replace("---", "-").
                       Replace("----", "-").
                       Replace("----", "-");
        }
    }
}