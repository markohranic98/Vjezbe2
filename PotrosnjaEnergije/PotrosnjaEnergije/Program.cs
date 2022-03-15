using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotrosnjaEnergije.Models;

namespace PotrosnjaEnergije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kuca kuca = new Kuca();
            Console.WriteLine("Cijena potrosene energije za proteklo razdovlje:");
            kuca.IzracunajIznosUkupno();

            Console.ReadLine();


        }
    }
}
