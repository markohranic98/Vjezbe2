using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobiliIProizvodaci.Models;
namespace AutomobiliIProizvodaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                Console.WriteLine("1 za dodavanje automobila");
                Console.WriteLine("2 za dodavanje proizvodaca");
                Console.WriteLine("3. za ispis svih automobila");
                Console.WriteLine("4. za ispis proizvodaca");
                Console.WriteLine("5. za ispis automobila grupiranih po proizvodacu");
                
                Console.WriteLine("6. za pretragu automobila po nazivu i rasponu cijena(min-max)");
                Console.WriteLine("7 iza izlaz iz aplikacije");

                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        {
                            Automobil noviAutomobil = null;
                            Console.WriteLine("Naziv automobila: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Cijena automobila: ");
                            int cijena = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesi proizvodaca");
                            string nazivProizvodaca = Console.ReadLine().ToUpper();
                            foreach (Proizvodac item in Proizvodac.Proizvodaci)
                            {
                                if (item.Naziv == nazivProizvodaca)
                                {
                                    Console.WriteLine("Automobil je dodan");
                                    noviAutomobil = new Automobil(naziv, cijena, nazivProizvodaca);
                                    break;
                                }
                            }
                            if(noviAutomobil == null)
                            {
                                Console.WriteLine("proizvodac ne postoji!");
                            }
                            
                            //ako netko zeli verziju zadatka di se proizvodac dodaje naknadno nek javi na discord

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Unesi naziv novog proizvodaca: ");
                            string naziv = Console.ReadLine().ToUpper();
                            Proizvodac noviProizvodac = new Proizvodac(naziv);
                            break;
                        }
                    case "3":
                        {
                            foreach (Automobil item in Automobil.Automobili)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "4":
                        {
                            foreach (Proizvodac item in Proizvodac.Proizvodaci)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "5": // grupirani po proizvodacu
                        {
                            foreach (Proizvodac item in Proizvodac.Proizvodaci)
                            {
                                Console.WriteLine("Naziv proizvodaca: " + item.Naziv);
                                Console.WriteLine("Automobili:\n---------------------------------");
                                foreach  (Automobil autoitem in Automobil.Automobili)
                                {
                                    if (autoitem.Proizvodac == item.Naziv)
                                    {
                                        Console.WriteLine(autoitem.IspisBezProizvodaca());
                                    }
                                }
                                Console.WriteLine("---------------------------------");
                            }
                            break;
                        }
                    case "6":
                        {
                            //ja sam ovu funkcio skuzio ko da se odjednom mora trazit i naziv i cijena
                            //postoji neka sansa da moraju bit 2 casea, jedan za pretragu po nazivu, drugi po cijeni
                            //al minimalne su promjene so whatever, takvo nes se pita na labosima
                            Console.WriteLine("Unesi ime koje zelis pretraziti");
                            string naziv = Console.ReadLine();
                            Console.Write("Unesi minimalnu cijenu: ");
                            int minCijena = int.Parse(Console.ReadLine());
                            Console.Write("Unesi maksimalnu cijenu: ");
                            int maxCijena = int.Parse(Console.ReadLine());
                            if (maxCijena < minCijena)
                            {
                                Console.WriteLine("Maksimalna cijena ne moze biti manja od min cijene!");
                                break;
                            }
                            int noResults = 0;
                            foreach(Automobil item in Automobil.Automobili)
                            {
                                if(item.Naziv.Contains(naziv) && item.Cijena > minCijena && item.Cijena < maxCijena)
                                {
                                    Console.WriteLine(item.Ispis());
                                    noResults++;
                                }
                            }
                            if (noResults == 0)
                            {
                                Console.WriteLine("Nije pronađen takav automobil");
                            }
                            break;
                        }
                    case "7":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Greska kod unosa naredbe");
                            break;
                        }
                }

            } while (izbor!="7");
        }
    }
}
