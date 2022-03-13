using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glasanje.Models;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GlasackaKutija glasackaKutija = new GlasackaKutija();

            do
            {
                Console.WriteLine("Unesite OIB: ");
                string unosOIB = Console.ReadLine();
                Console.WriteLine("Unesite odabir Z P S:");
                string unosGlas = Console.ReadLine();
                glasackaKutija.Glasaj(unosOIB, unosGlas);
                glasackaKutija.DohvatiRezultateGlasa();
            }while(true);
        }
    }
}
