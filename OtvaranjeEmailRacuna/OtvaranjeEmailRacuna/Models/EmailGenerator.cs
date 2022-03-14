using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna.Models
{
    internal class EmailGenerator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            return ime.ToLower() + "." + prezime.ToLower() + "@foi.hr";
        }  

        public string GenerirajSkraceniEmail(string ime, string prezime)
        {
            return ime.Substring(0,1).ToLower() + prezime.Substring(0,5).ToLower() + "@foi.hr";
        }



    }
}
