using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta.Models
{
    public class Linija
    {
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public int Udaljenost { get; set; }

        public Linija(string polaziste, string odrediste, int udaljenost)
        {
            this.Polaziste = polaziste;
            this.Odrediste = odrediste; 
            this.Udaljenost = udaljenost;    
        }

    }
}
