using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTImeri.Models
{
    abstract class Vozilo
    {
        public string Naziv { get; set; }   

        public enum VrstaVozila
        {
            Automobil,
            Motocikl
        }

        public VrstaVozila Vrsta = new VrstaVozila();
             
    }
}
