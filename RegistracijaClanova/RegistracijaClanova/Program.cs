using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistracijaClanova.Models;

namespace RegistracijaClanova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi email korisnika:");
            string email = Console.ReadLine();
            Console.WriteLine("Unesi lozinku: ");
            string lozinka = Console.ReadLine();

            Registrator registrator = new Registrator();
            Console.WriteLine(registrator.RegistrirajClana(email,lozinka));

            Console.ReadLine();
        }
    }
}
