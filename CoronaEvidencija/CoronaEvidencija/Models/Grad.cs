using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaEvidencija.Models
{
    internal class Grad
    {
        public string NazivGrada { get; set; }
        public List<KoronaZapis> KoronaZapisi = new List<KoronaZapis>();
        public Grad(string NazivGrada)
        {
            this.NazivGrada = NazivGrada;
        }

        public void DodajKoronaZapise()
        {
            KoronaZapis noviZapis = new KoronaZapis();
            Console.WriteLine("Koliko je bilo zarazenih danas ("+noviZapis.Datum.ToShortDateString()+") : ");
            noviZapis.BrojZarazenih = int.Parse(Console.ReadLine());
            this.KoronaZapisi.Add(noviZapis);
            return;
        }

        public void IspisiKoronaZapise()
        {
            foreach (KoronaZapis item in this.KoronaZapisi)
            {
                Console.WriteLine("Datuma ("+item.Datum.ToShortDateString()+") bilo je " + item.BrojZarazenih + " broj zarazenih ");
            }
            return;
        }
    }
}
