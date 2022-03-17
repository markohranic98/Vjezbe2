using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senzori1.Models;
namespace Senzori1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeteoStanica meteo = new MeteoStanica();
            Console.WriteLine("U kojoj mjernoj jedinici zelite izracun prosjecne temperature(C/K):");
            string unos = Console.ReadLine().ToUpper();
            if (unos == "C")
            {
                Console.WriteLine(meteo.DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere.Celzijus).ToString());
            }
            else if(unos == "K")
            {
                Console.WriteLine(meteo.DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere.Kelvin).ToString()); ;
            }
            else
            {
                Console.WriteLine("Krivi unos");
            }
            Console.ReadLine();
        }
    }
}
