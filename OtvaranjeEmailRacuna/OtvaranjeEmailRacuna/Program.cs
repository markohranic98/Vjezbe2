using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtvaranjeEmailRacuna.Models;

namespace OtvaranjeEmailRacuna
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            EmailServer server = new EmailServer();
            string prezime = "";
            string ime = "";
            do
            {
                Console.WriteLine("Unesi ime");
                ime = Console.ReadLine();
                Console.WriteLine("Unesi prezime");
                prezime = Console.ReadLine();
            } while (prezime.Length < 5);


            KorisnickiRacun noviRacun = new KorisnickiRacun();
            noviRacun = server.KreirajKorisnickiRacun(ime, prezime);
            Console.WriteLine(noviRacun.Ime);
            Console.WriteLine(noviRacun.Prezime);
            Console.WriteLine(noviRacun.Email);
            Console.WriteLine(noviRacun.SkraceniEmail);
            Console.WriteLine(noviRacun.Lozinka);

            Console.Read();
        }
    }
}
