using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prvenstvo.Models;
namespace Prvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            PrvenstvoClass prvenstvo = new PrvenstvoClass();
            do
            {
                Console.WriteLine("1 unesi reprezentaciju");
                Console.WriteLine("2 evidentiraj utakmicu");
                Console.WriteLine("3 ispisi tablicu rezultat");
                Console.WriteLine("4 ispisi bodovnu ljestvicu");
                Console.WriteLine("0 izlaz");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        prvenstvo.UnesiReprezentaciju();
                        break;
                    case "2":
                        prvenstvo.DodajUtakmicu();
                        break;
                    case "3":
                        prvenstvo.GenerirajTablicuRezultata();
                        break;
                    case "4":
                        prvenstvo.GenerirajBodovnuLjestvicu();
                        break;
                    default:
                        break;
                }

            } while (izbor != "0");
            
            
        }
    }
}
