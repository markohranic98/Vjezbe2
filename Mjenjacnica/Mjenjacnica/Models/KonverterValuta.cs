using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class KonverterValuta
    {
        public double Konvertiraj(double iznos, string odredisnaValuta)
        {
            //trebam ić po listi tecajeva i dohvatiti onaj koji ima odredisnaValuta == kod "EUR" == "EUR"
            TecajnaLista lista = new TecajnaLista();
            double conversionRate = 0; // tu cu spremit konverziju    , za komentiranje vise linija CTRL + K PA C/U
            //foreach (Tecaj item in lista.ListaTecajeva)    
            //{
            //    if(item.Kod == odredisnaValuta)
            //    {
            //        conversionRate = item.ConversionRate;
            //        break;
            //    }
            //}
            

            //nasli ste se na ovom dijelu koda nakon pokretanja jer ste krivo unijeli oznaku valute ()
            conversionRate = lista.ListaTecajeva.Find(x => x.Kod == odredisnaValuta).ConversionRate;
            return iznos / conversionRate;
        }
    }
}
