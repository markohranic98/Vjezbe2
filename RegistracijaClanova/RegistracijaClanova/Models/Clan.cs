using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova.Models
{
    internal class Clan
    {
        public string EmailAdresa { get; set; }
        public string Lozinka { get; set; }
        public Clan(string emailAdresa, string lozinka)
        {
            this.EmailAdresa = emailAdresa;
            this.Lozinka = lozinka;
        }
    }
}
