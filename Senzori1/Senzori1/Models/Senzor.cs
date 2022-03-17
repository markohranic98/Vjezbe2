using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori1.Models
{
    internal class Senzor
    {
        public string Oznaka { get; set; }
        public double Vrijednost { get; set; }
        public enum JedinicaMjere
        {
            Celzijus,Kelvin
        }

        public JedinicaMjere Jedinica = new JedinicaMjere();

        public Senzor(string oznaka, double vrijednost, JedinicaMjere jedinica)
        {
            this.Oznaka = oznaka;
            this.Vrijednost = vrijednost;
            this.Jedinica = jedinica;
        }
    }
}
