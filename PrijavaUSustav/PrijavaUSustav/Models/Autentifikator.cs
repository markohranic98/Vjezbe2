using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaUSustav.Models
{
    internal class Autentifikator
    {
        private List<Korisnik> listaKorisnika;

        public Autentifikator()
        {
            listaKorisnika = new List<Korisnik>();
            listaKorisnika.Add(new Korisnik("ssusac","mihai"));
            listaKorisnika.Add(new Korisnik("mhranic","5JGNHn6k"));
            listaKorisnika.Add(new Korisnik("kfranovic","karla"));
        }

        private Korisnik DohvatiKorisnika(string userName)
        {
            return listaKorisnika.Find(x => x.KorisnickoIme == userName) == null ? null : listaKorisnika.Find(x => x.KorisnickoIme == userName);
        }

        public string PrijaviKorisnika(string korisnickoIme, string lozinka)
        {

            if(DohvatiKorisnika(korisnickoIme) == null)
            {
                return "Ne postoji korisnik sa navedenim korisnickim imenom";
            }
            else if(DohvatiKorisnika(korisnickoIme)!=null && DohvatiKorisnika(korisnickoIme).Lozinka != lozinka)
            {
                return "Pogresno upisana lozinka!";
            }
            else if(DohvatiKorisnika(korisnickoIme) != null && DohvatiKorisnika(korisnickoIme).Lozinka == lozinka)
            {
                return "Uspjesna prijava";
            }

           return "greska";
        }

    }
}
