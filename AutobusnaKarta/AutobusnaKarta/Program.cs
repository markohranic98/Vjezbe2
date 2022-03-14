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
            // ovo i dalje nije najbolja verzija ovog zadatka, al je pretesko za dreuge vjezbe slozit drugacije odnosno problem je kod unosa
            //ako se unese Novi Marof Varazdin Povratna npr ne radi
            // al ne da mi se sad slagat to fakat, i valjda nece bit krivo (99.9%)
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            //ja cu rijesit ovaj na "bolji" nacin
            Console.WriteLine("Unesite polaziste, odrediste i tip karte");
            string[] unos = Console.ReadLine().Split(' ');
            Console.WriteLine(unos.Length);
            if(unos.Length == 3)
            {
                Console.WriteLine(kolodvor.KupiKartu(unos[0], unos[1], unos[2])); 
            }
            if(unos.Length == 4)
            {
                Console.WriteLine(kolodvor.KupiKartu(unos[0], unos[1] + " " + unos[2], unos[3])); 
            }
                
            Console.ReadLine();
        }
    }
}
