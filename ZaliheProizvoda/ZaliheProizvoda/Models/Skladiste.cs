using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliheProizvoda.Models
{
    internal class Skladiste
    {
        public List<Proizvod> Proizvodi = new List<Proizvod>();
        // ja radim da program automatski stavi da je stanje 0 na proizvodu pa mi moramo povecati ,to se pita profesora ako niste sigurni
        public void DodajProizvod(Proizvod proizvod)
        {
            
            if(Proizvodi.Find(x=>x.Naziv == proizvod.Naziv) != null)
            {
                Console.WriteLine("Vec postoji taj naziv proizvoda");
                return;
            }
            this.Proizvodi.Add(proizvod);
            return;
        }

        public void UkloniProizvod(Proizvod proizvod)
        {
            if(Proizvodi.Find(x=>x.Naziv==proizvod.Naziv)!= null)
            {
                Proizvodi.Remove(proizvod);
                Console.WriteLine("Proizvod izbrisan");
                return;
            }
            Console.WriteLine("Nismo nasli proizvod");
            return;
        }

        public Proizvod DohvatiProizvod(string naziv)
        {
            if (Proizvodi.Find(x => x.Naziv == naziv) != null)
            {
                return Proizvodi.Find(x=> x.Naziv == naziv);
            }
            Console.WriteLine("Nismo pronasli taj proizvod");
            return null;
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            return Proizvodi;
        }

        public double IzracunajUkupnuVrijednostZaliha()
        {
            return Proizvodi.Sum(x => x.IzracunajVrijednostZaliha());
        }
    }
}
