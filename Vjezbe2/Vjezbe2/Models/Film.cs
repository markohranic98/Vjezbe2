using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe2.Models
{
    public class Film
    {
        public string Naslov;
        public int Godina;
        public List<Glumac> Glumci = new List<Glumac>();
        public static List<Film> Filmovi = new List<Film>();
        public Film(string Naslov, int Godina)
        {
            this.Naslov = Naslov;
            this.Godina = Godina;

            Filmovi.Add(this);
        }

        public void DodajGLumca(Glumac glumac)
        {
            if (!Glumci.Contains(glumac))
            {
                Glumci.Add(glumac);
            }

            return;
        }

        public string Ispis()
        {
            string returnMe = "";
            returnMe = this.Naslov + " - " + this.Godina.ToString() + " (";
            foreach (Glumac item in this.Glumci)
            {
                //Tom Cruise, 
                returnMe += item.Ispis();
            }
            returnMe += ")";
            return returnMe;
        }
    }
}
