using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliIProizvodaci.Models
{
    internal class Proizvodac
    {
        public string Naziv;
        public static List<Proizvodac> Proizvodaci = new List<Proizvodac>();

        public Proizvodac(string Naziv)
        {
            this.Naziv = Naziv;
            Proizvodaci.Add(this);
        }

        public string Ispis()
        {
            return this.Naziv;
        }
    }
}
