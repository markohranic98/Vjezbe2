
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliIProizvodaci.Models
{
    internal class Automobil
    {
        public string Naziv;
        public int Cijena;
        public string Proizvodac;
        public static List<Automobil> Automobili = new List<Automobil>();
        public Automobil(string Naziv,int Cijena,string Proizvodac)
        {
            this.Naziv = Naziv; 
            this.Cijena = Cijena;
            this.Proizvodac = Proizvodac;
            Automobili.Add(this);
        }

        public string Ispis()
        {
            string returnMe = "Naziv: "+Naziv+"\nCijena: "+Cijena+"\nProizvodac: "+Proizvodac;
            return returnMe;
        }

        public string IspisBezProizvodaca()
        {
            string returnMe = "Naziv: " + Naziv + "\nCijena: " + Cijena;
            return returnMe;
        }

    }
}
