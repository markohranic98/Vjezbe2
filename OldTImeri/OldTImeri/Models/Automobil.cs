using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTImeri.Models
{
    internal class Automobil : Vozilo
    { 

        public Automobil(string naziv)
        {
            this.Naziv = naziv;
            this.Vrsta = VrstaVozila.Automobil;
        }
    }
}
