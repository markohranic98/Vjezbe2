using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliheProizvoda.Models
{
    internal class Proizvod
    {
        public string Naziv { get; set; }
        public double JedinicnaCijena { get; set; }
        public int Stanje { get; set; }

        public Proizvod(string naziv, double jedinicnaCijena,int stanje)
        {
            this.Naziv = naziv;
            this.JedinicnaCijena = jedinicnaCijena;
            this.Stanje = stanje;
        }

        //ovaj konstruktor  mozda nece bit potreban
        public Proizvod(string naziv, double jedinicnaCijena)
        {
            this.Naziv= naziv;
            this.JedinicnaCijena = jedinicnaCijena;
            this.Stanje = 0;
        }

        public double IzracunajVrijednostZaliha()
        {
            return this.JedinicnaCijena * this.Stanje;
        }

        public void DodajNaStanje(int kolicina)
        {
            if (kolicina > 0)
            {
                Console.WriteLine("TU SAM");
                this.Stanje += kolicina;
                return;
            }
            Console.WriteLine("Nije moguce dodat 0 ili negativno stanje");
        }

        public void OduzmiSaStanja(int kolicina)
        {
            if(this.Stanje>=kolicina && kolicina > 0)
            {
                Console.WriteLine("TU SAM");
                this.Stanje -= kolicina;
                return;
            }
            Console.WriteLine("Nije moguce oduzimat 0 ili negativno, kolicina mora biti veca od stanja");
        }

    }
}
