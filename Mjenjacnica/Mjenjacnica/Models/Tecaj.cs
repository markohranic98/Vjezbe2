using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class Tecaj
    {
        public string Naziv { get; set; } //euro
        public string Kod { get; set; }  // EUR
        public double ConversionRate { get; set; }  // 7.5
        public Tecaj(string naziv, string kod, double conversionRate)
        {
            this.Naziv = naziv;
            this.Kod = kod;
            this.ConversionRate = conversionRate;
        }

    }
}
