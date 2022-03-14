using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTImeri.Models
{
    internal class Motocikl : Vozilo
    {
        public Motocikl(string naziv)
        {
            this.Vrsta = VrstaVozila.Motocikl;
            this.Naziv = naziv;
        }
    }
}
