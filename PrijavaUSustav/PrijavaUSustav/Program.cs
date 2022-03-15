using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijavaUSustav.Models;
namespace PrijavaUSustav
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Autentifikator autentifikator = new Autentifikator();
            Console.WriteLine("PRIJAVA U SUSTAV");
            Console.WriteLine("Korisnicko ime:");
            string userName = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            Console.WriteLine(autentifikator.PrijaviKorisnika(userName, password)); 
            Console.ReadLine();
        }
    }
}
