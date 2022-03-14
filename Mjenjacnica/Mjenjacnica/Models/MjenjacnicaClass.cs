using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class MjenjacnicaClass
    {
        private KonverterValuta konverter = new KonverterValuta();
        private TecajnaLista tecajnaLista = new TecajnaLista();

        public Potvrda PromijeniNovac(double iznos, string odredisnaValuta)
        {
            Potvrda potvrda = new Potvrda();
            potvrda.Datum=DateTime.Now;
            potvrda.IznosZaPromjenu = iznos;
            potvrda.Iznos = konverter.Konvertiraj(iznos, odredisnaValuta);
            potvrda.KodTecaja = tecajnaLista.ListaTecajeva.Find(x => x.Kod == odredisnaValuta).Kod;
            potvrda.Tecaj = tecajnaLista.ListaTecajeva.Find(x => x.Kod == odredisnaValuta).ConversionRate;
            potvrda.Isplata = potvrda.Iznos * 0.95;
            potvrda.Naknada = potvrda.Iznos - potvrda.Isplata;
            return potvrda;
        }
        public void IspisPotvrde(Potvrda potvrda)
        {
            Console.WriteLine(potvrda.Datum);
            Console.WriteLine(potvrda.IznosZaPromjenu);
            Console.WriteLine(potvrda.Tecaj);
            Console.WriteLine(potvrda.Iznos);
            Console.WriteLine(potvrda.Naknada);
            Console.WriteLine(potvrda.Isplata);
        }
    }
}
