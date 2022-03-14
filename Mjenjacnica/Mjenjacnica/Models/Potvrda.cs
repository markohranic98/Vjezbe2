using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class Potvrda
    {
        public DateTime Datum { get; set; }
        public double IznosZaPromjenu { get; set; }
        public string KodTecaja { get; set; }
        public double Tecaj { get; set; }
        public double Iznos { get; set; }
        public double Naknada { get; set; }
        public double Isplata { get; set; }


    }
}
