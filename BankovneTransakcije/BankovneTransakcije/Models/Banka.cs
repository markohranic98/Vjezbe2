using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije.Models
{
    internal class Banka
    {
        private List<Racun> racuni;

        public Banka()
        {
            racuni = new List<Racun>();
            racuni.Add(new Racun("HR11",100000));
            racuni.Add(new Racun("HR22",50000));
            racuni.Add(new Racun("HR33",12000));
            racuni.Add(new Racun("HR44",36000));
        }

        private Racun DohvatiRacun(string iban)
        {
            foreach (Racun item in racuni)
            {
                if (iban == item.IBAN)
                {
                    return item;
                }
            }
            
            return null;
        }

        public Transakcija IzvrsiPlacanje(string ibanPlatitelja, string ibanPrimatelja, double iznos)
        {
            //ovo se da jos optimizirat al ne da mi se sad
            int pronaden = 0;
            foreach (Racun item in racuni)
            {
                if (ibanPrimatelja == item.IBAN || ibanPlatitelja == item.IBAN)
                {
                    pronaden++;
                }
            }
            if (pronaden < 2)
            {
                Console.WriteLine("Nismo pronasli platitelja ili primatelja");
            }
            else
            {
                Racun racunPlatitelj = racuni.Find(x => x.IBAN.Equals(ibanPlatitelja));
                Racun racunPrimatelj = racuni.Find(x => x.IBAN.Equals(ibanPrimatelja));
                racunPrimatelj.Stanje += iznos;
                racunPlatitelj.Stanje -= iznos;
                return new Transakcija(racunPlatitelj,racunPrimatelj, iznos);
            }
            Console.WriteLine("Greska u funkciji ");
            return null;
            
        }
    }
}
