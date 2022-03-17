using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori1.Models
{
    internal class MeteoStanica
    {
        private List<Senzor> senzori;

        public MeteoStanica()
        {
            this.senzori = new List<Senzor>();
            this.senzori.Add(new Senzor("Senzor 1",8.4,Senzor.JedinicaMjere.Celzijus));
            this.senzori.Add(new Senzor("Senzor 2",281.5,Senzor.JedinicaMjere.Kelvin));
            this.senzori.Add(new Senzor("Senzor 3",8.9,Senzor.JedinicaMjere.Celzijus));
            this.senzori.Add(new Senzor("Senzor 4",9.1,Senzor.JedinicaMjere.Celzijus));

        }

        private double Pretvori(Senzor.JedinicaMjere izJedinica, Senzor.JedinicaMjere uJedinicu,double vrijednost)
        {
            if(izJedinica == Senzor.JedinicaMjere.Celzijus && uJedinicu == Senzor.JedinicaMjere.Kelvin)
            {
                return vrijednost + 273.15;
            }
            else if(izJedinica == Senzor.JedinicaMjere.Kelvin && uJedinicu == Senzor.JedinicaMjere.Celzijus)
            {
                return vrijednost - 273.15;
            }
            return 0;
        }

        public double DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere jedinicaMjere)
        {
            double sum = 0;
            
            
                foreach (var item in senzori)
                {
                    if(item.Jedinica==Senzor.JedinicaMjere.Celzijus && jedinicaMjere == Senzor.JedinicaMjere.Kelvin)
                    {
                        sum += Pretvori(Senzor.JedinicaMjere.Celzijus,Senzor.JedinicaMjere.Kelvin,item.Vrijednost);
                    }
                    else if(item.Jedinica == Senzor.JedinicaMjere.Kelvin && jedinicaMjere == Senzor.JedinicaMjere.Celzijus)
                    {
                        sum +=Pretvori(Senzor.JedinicaMjere.Kelvin,Senzor.JedinicaMjere.Celzijus,item.Vrijednost);
                    }
                    else
                    {
                        sum += item.Vrijednost;
                    }
                Console.WriteLine(sum);
                }
            
            return sum/senzori.Count;
        }

    }
}
