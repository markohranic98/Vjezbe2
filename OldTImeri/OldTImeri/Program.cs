using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldTImeri.Models;

namespace OldTImeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos = "";
            List<Vozilo> vozila = new List<Vozilo>();
            do
            {
                
                Console.WriteLine("1. Dodavanje vozila");
                Console.WriteLine("2. Ispis vozila");
                Console.WriteLine("3. Izlaz");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesi naziv vozila: ");
                            string nazivVozila = Console.ReadLine();
                            Console.WriteLine("Unesi tip vozila Automobil/Motocikl:"); // AuToMoBiL
                            string tipVozila = Console.ReadLine();

                            if(tipVozila.ToLower() == "automobil")
                            {
                                vozila.Add(new Automobil(nazivVozila));
                            }
                            else if(tipVozila.ToLower() == "motocikl")
                            {
                                vozila.Add(new Motocikl(nazivVozila));
                            }
                            else
                            {
                                Console.WriteLine("Tip vozila je bio krivi");
                            }
                            break;
                        }
                    case "2":
                        {
                            foreach (Vozilo item in vozila)
                            {
                                Console.WriteLine("Tip vozila: " + item.Vrsta);
                                Console.WriteLine("Naziv vozila: " + item.Naziv);

                            }
                            Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Krivi unos");
                            break;
                        }
                }
            } while (unos!="3");
        }
    }
}
