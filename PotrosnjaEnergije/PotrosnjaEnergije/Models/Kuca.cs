using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaEnergije.Models
{
    internal class Kuca
    {
        public List<Brojilo> Brojila;

        public Kuca()
        {
            this.Brojila = new List<Brojilo>();
            this.Brojila.Add(new Brojilo("HEP_101",Brojilo.TipBrojila.Struja,34235,32150));
            this.Brojila.Add(new Brojilo("TP_222",Brojilo.TipBrojila.Plin,11500,10400));
            this.Brojila.Add(new Brojilo("VAR_123",Brojilo.TipBrojila.Voda,16225,16100));
        }

        private double DohvatiCijenEnergenata(Brojilo.TipBrojila tipBrojila)
        {
            if(tipBrojila == Brojilo.TipBrojila.Struja)
            {
                return 0.1;
            }
            else if (tipBrojila == Brojilo.TipBrojila.Plin)
            {
                return 0.2;
            }
            else if (tipBrojila == Brojilo.TipBrojila.Voda)
            {
                return 3.5;
            }
            return 0;
        }

        public double IzracunajIznosZaBrojilo(Brojilo brojilo)
        {
            Console.WriteLine($"Brojilo: {brojilo.Naziv} ({brojilo.Tip}) = {brojilo.OcitajPotrosnju() * DohvatiCijenEnergenata(brojilo.Tip)} ");
            return brojilo.OcitajPotrosnju() * DohvatiCijenEnergenata(brojilo.Tip);
        }
        public double IzracunajIznosUkupno()
        {
            double suma = 0;
            foreach (var item in Brojila)
            {
                suma += IzracunajIznosZaBrojilo(item);
            }
            Console.WriteLine("UKUPNO: "+suma);
            return suma;
        }
    }
}
