using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KucnaKnjiznica3.Models;
namespace KucnaKnjiznica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knjiznica knjiznica = new Knjiznica();
            Console.WriteLine("Unesite ime i prezime osobe kojoj posudujemo knjigu:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige");
            string isbn = Console.ReadLine();
            knjiznica.PosudiKnjigu(ime,isbn);
            Console.ReadLine();
        }
    }
}
