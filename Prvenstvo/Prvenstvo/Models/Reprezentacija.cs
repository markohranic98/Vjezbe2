using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo.Models
{
    internal class Reprezentacija
    {
        public string Oznaka { get; set; }
        public string Naziv { get; set; }

        public Reprezentacija(string oznaka, string naziv)
        {
            this.Oznaka = oznaka;
            this.Naziv = naziv;
        }
        public Reprezentacija()
        {

        }
    }
}
