using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaEnergije.Models
{
    internal class Brojilo
    {
        public string Naziv { get; set; }
        public enum TipBrojila
        {
            Struja,
            Plin,
            Voda
        }
        public TipBrojila Tip = new TipBrojila();

        private double ocitanje { get; set; }
        private double zadnjeStanje { get; set; }


        public Brojilo(string naziv, TipBrojila tip, double _ocitanje, double _zadnjeStanje)
        {
            this.zadnjeStanje = _zadnjeStanje;
            this.ocitanje = _ocitanje;
            this.Tip = tip;
            this.Naziv = naziv;
        }


        public double OcitajPotrosnju()
        {
            return ocitanje - zadnjeStanje;
        }
    }
}
