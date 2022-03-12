using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankovneTransakcije.Models;
namespace BankovneTransakcije
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banka banka = new Banka();
            Console.WriteLine("Unesite IBAN platitelja");
            string ibanPlatitelja = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja");
            string ibanPrimatelja = Console.ReadLine();
            Console.WriteLine("Iznos placanja");
            double iznosPlacanja = double.Parse(Console.ReadLine());

            Transakcija novaTransakcija = banka.IzvrsiPlacanje(ibanPlatitelja, ibanPrimatelja, iznosPlacanja);
            if(novaTransakcija != null)
            {
                Console.WriteLine("Novo stanje racuna: " + novaTransakcija.Platitelj.IBAN + " je: " + novaTransakcija.Platitelj.Stanje);
                Console.WriteLine("Novo stanje racuna: " + novaTransakcija.Primatelj.IBAN + " je: " + novaTransakcija.Primatelj.Stanje);
            }
            
            Console.Read();
            
        }
    }
}
