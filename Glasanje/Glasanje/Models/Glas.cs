using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje.Models
{
    internal class Glas
    {
        public string OIB { get; set; }
        public string Odabir { get; set; }

        public Glas(string oib, string odabir)
        {
            this.Odabir = odabir;
            this.OIB = oib;
        }
    }
}
