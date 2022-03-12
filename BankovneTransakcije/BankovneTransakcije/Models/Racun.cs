using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije.Models
{
    internal class Racun
    {
        public string IBAN { get; set; }
        public double Stanje { get; set; }

        public Racun(string IBAN, double Stanje)
        {
            this.IBAN = IBAN;
            this.Stanje = Stanje;   
        }
    }
}
