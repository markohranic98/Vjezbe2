using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica2.Models
{
    internal class Knjiga
    {
        public string Naslov { get; set; }
        public bool Dostupno { get; set; }
        public string Osoba { get; set; }

        public Knjiga(string naslov)
        {
            this.Naslov = naslov;
            this.Dostupno = true;
            this.Osoba = "";
        }

        public string DohvatiOpis()
        {
            return $"Naslov:{this.Naslov}, Dostupno:{this.Dostupno}, Osoba:{this.Osoba}";
        }
    }
}
