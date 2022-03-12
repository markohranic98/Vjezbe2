using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutobusnaKarta.Models;

namespace AutobusnaKarta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi podatke o karti");
            string[] unos = Console.ReadLine().Split(' ');
            
            //Linija novaLinija = new Linija(unos[0],unos[1],int.Parse(unos[2])); ovo ne kuzim ni ja na ovom zadatku zas opce trebamo linije
            //novaLinija.Ispisi();
            AutobusniKolodvor kolodvorApp = new AutobusniKolodvor();
            Console.WriteLine(kolodvorApp.KupiKartu(unos[0], unos[1], unos[2])); 
            Console.ReadKey();
        }
    }
}
