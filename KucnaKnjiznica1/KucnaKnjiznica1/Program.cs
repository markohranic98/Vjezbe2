using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KucnaKnjiznica1.Models;

namespace KucnaKnjiznica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knjiznica knjiznica = new Knjiznica();
            Console.WriteLine("Unesite ISBN knjige koji posudujete: ");
            string isbn = Console.ReadLine();
            knjiznica.Posudi(isbn);
            Console.ReadLine();
        }
    }
}
