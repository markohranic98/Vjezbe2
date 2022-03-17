using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova.Models
{
    internal class Registrator
    {
        private List<Clan> listaClanova;

        public Registrator()
        {
            this.listaClanova = new List<Clan>();
            this.listaClanova.Add(new Clan("mhranic@foi.hr","123456"));
            this.listaClanova.Add(new Clan("btomas@foi.hr","123456"));
            this.listaClanova.Add(new Clan("zstapic@foi.hr","123456"));
        }

        private bool EmailZauzet(string email)
        {
            return listaClanova.Find(x => x.EmailAdresa == email) != null ? true : false; //true zautet je false nije zauzet
        }

        public string RegistrirajClana(string email, string lozinka)
        {
            string message = "";

            Validator validator = new Validator();

            if (!validator.ValidirajEmail(email))
            {
                message += "\nEmail adresa je neispravnog oblika!";
            }
            if (!validator.ValidirajLozinku(lozinka))
            {
                message += "\nLozinka mora imat izmedu 6 i 10 znakova";
            }
            if (EmailZauzet(email))
            {
                message += "\nVec postoji clan sa navedenim emailom";
            }
            if (message == "")
            {
                message = $"Član {email} je uspjesno registriran!";
                this.listaClanova.Add(new Clan(email, lozinka));
            }


            return message;
        }

    }
}
