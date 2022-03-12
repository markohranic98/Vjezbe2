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

        public static List<Linija> Linije = new List<Linija>(); // ovo mozda ne treba tu

        public Linija() //prazan ctor
        { 
        }

        public Linija(string Polaziste,string Odrediste,int Udaljenost)
        {
            this.Odrediste = Odrediste;
            this.Polaziste = Polaziste;
            this.Udaljenost = Udaljenost;
            Linije.Add(this);
        }
        
        public void Ispisi() // ova metoda ne treba, to je bilo testing
        {
            foreach (Linija item in Linije)
            {
                Console.WriteLine(item.Odrediste + " " + item.Udaljenost);
            }
        }

    }
}
