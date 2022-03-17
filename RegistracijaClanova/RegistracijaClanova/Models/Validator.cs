using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova.Models
{
    internal class Validator
    {
        public bool ValidirajEmail(string emailAdresa)
        {
            // if(emailAdresa.Contains("@") && emailAdresa.Contains("foi.hr"))
            if (emailAdresa.EndsWith("@foi.hr"))
            {
                return true;
            }
            return false;
        }

        public bool ValidirajLozinku(string lozinka)
        {
            return lozinka.Length > 5 && lozinka.Length < 11 ? true : false;
        }
    }
}
