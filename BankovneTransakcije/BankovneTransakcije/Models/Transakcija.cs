using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije.Models
{
    internal class Transakcija
    {
        public Racun Platitelj { get; set; }
        public Racun Primatelj { get; set; }
        public double Iznos { get; set; }

        public Transakcija(Racun Platitelj, Racun Primatelj,double Iznos)
        {
            this.Platitelj = Platitelj;
            this.Primatelj = Primatelj;
            this.Iznos = Iznos;
        }
    }
}
