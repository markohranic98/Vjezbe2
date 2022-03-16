using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KucnaKnjiznica2.Models;

namespace KucnaKnjiznica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ovaj zadatak se mozda mora stavit u do while petlju al not sure
            Knjiznica knjiznica = new Knjiznica();
            Console.WriteLine("Unesite naslov knjige koju posudujete: ");
            string naslovKnjige = Console.ReadLine();
            Console.WriteLine("Unesite ime osobe kojoj posudujete knjigu:");
            string osoba = Console.ReadLine();
            knjiznica.Posudi(naslovKnjige,osoba);

            foreach (var item in knjiznica.PopisKnjiga)
            {
                Console.WriteLine(item.DohvatiOpis());
            }
            Console.Read();

        }
    }
}
