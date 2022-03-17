using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliheProizvoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("1 Dodaj proizvod na skladiste");
                Console.WriteLine("2 Povecaj kolicinu proizvoda");
                Console.WriteLine("3 smanji kolicinu proizvoda");
                Console.WriteLine("4 Ispisi stanje skladista");
                Console.WriteLine("5 izlaz");

            } while (izbor!=5);
        }
    }
}
