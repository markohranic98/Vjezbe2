using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredlaganjeFilma.Models
{
    internal class StreamingServis
    {
        public List<Film> Filmovi;

        public StreamingServis()
        {
            Filmovi = new List<Film>();
            Filmovi.Add(new Film("Film 1",Film.Zanrovi.Komedija,88,false));
            Filmovi.Add(new Film("Film 2",Film.Zanrovi.Akcija,95,false));
            Filmovi.Add(new Film("Film 3",Film.Zanrovi.Horor,70,true));
            Filmovi.Add(new Film("Film 4",Film.Zanrovi.Komedija,120,false));
            Filmovi.Add(new Film("Film 5",Film.Zanrovi.Akcija,110,true));
            Filmovi.Add(new Film("Film 6",Film.Zanrovi.Horor,99,false));
            Filmovi.Add(new Film("Film 7",Film.Zanrovi.Komedija,75,false));
            Filmovi.Add(new Film("Film 8",Film.Zanrovi.Akcija,80,true));
            Filmovi.Add(new Film("Film 9",Film.Zanrovi.Horor,81,true));
            Filmovi.Add(new Film("Film 10",Film.Zanrovi.Komedija,99,true));
        }

        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            return Filmovi.FindAll(item => item.VecGledan == false);
        }

        public Film PredloziFilm()
        {
            Random rand = new Random();
            int index = rand.Next(DohvatiFilmoveKojeNisamGledao().Count);
            return DohvatiFilmoveKojeNisamGledao()[index];
        }
    }
}
