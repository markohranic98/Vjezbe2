using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna.Models
{
    internal class EmailServer
    {
        public KorisnickiRacun KreirajKorisnickiRacun(string ime,string prezime)
        {
            EmailGenerator emailGenerator = new EmailGenerator();
            LozinkaGenerator lozinkaGenerator = new LozinkaGenerator();

            string email = emailGenerator.GenerirajEmail(ime, prezime);
            string skraceniEmail = emailGenerator.GenerirajSkraceniEmail(ime, prezime);
            string lozinka = lozinkaGenerator.GenerirajLozinku(ime, prezime);

            KorisnickiRacun korisnickiRacun = new KorisnickiRacun(ime,prezime,email,skraceniEmail,lozinka);

            return korisnickiRacun;
        }
    }
}
