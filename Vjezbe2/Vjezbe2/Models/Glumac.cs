using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe2.Models
{
    public  class Glumac
    {

        public string Ime;
        public string Prezime;
        public static List<Glumac> Glumci = new List<Glumac>();
        public Glumac(string Ime, string Prezime)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            Glumci.Add(this);
        }

        public string Ispis()
        {
            return this.Ime + " " + this.Prezime + " ";
        }
    }
}
