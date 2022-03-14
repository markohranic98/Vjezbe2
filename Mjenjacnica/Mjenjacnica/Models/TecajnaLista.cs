using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class TecajnaLista
    {

        public List<Tecaj> ListaTecajeva;
        public TecajnaLista()
        {
            this.ListaTecajeva = new List<Tecaj>();
            this.ListaTecajeva.Add(new Tecaj("euro","EUR",7.5));
            this.ListaTecajeva.Add(new Tecaj("american dollar","USD",7));
            this.ListaTecajeva.Add(new Tecaj("british pound","GBP",8.9)); // nisam provjerio
        }
    }
}
