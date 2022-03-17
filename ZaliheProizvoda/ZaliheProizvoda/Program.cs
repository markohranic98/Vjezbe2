using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaliheProizvoda.Models;
namespace ZaliheProizvoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skladiste skladiste = new Skladiste();
            int izbor = 0;
            do
            {
                Console.WriteLine("1 Dodaj proizvod na skladiste");
                Console.WriteLine("2 Ukloni proizvod sa skladista");
                Console.WriteLine("3 Povecaj kolicinu proizvoda");
                Console.WriteLine("4 smanji kolicinu proizvoda");
                Console.WriteLine("5 Ispisi stanje skladista");
                Console.WriteLine("6 izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        {
                            Console.WriteLine("Unesi naziv proizvoda:");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Unesi cijenu proizvoda: ");
                            double cijena = double.Parse(Console.ReadLine());

                            skladiste.DodajProizvod(new Proizvod(naziv, cijena));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Unesi naziv proizvoda koji zelis ukloniti:");
                            string naziv = Console.ReadLine();
                            skladiste.UkloniProizvod(skladiste.DohvatiProizvod(naziv));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Unesi naziv proizvoda i kolicinu koju zelis dodati");
                            string naziv = Console.ReadLine();
                            int kolicina = int.Parse(Console.ReadLine());
                            if (skladiste.Proizvodi.Find(x => x.Naziv == naziv) != null)
                            {
                                skladiste.DohvatiProizvod(naziv).DodajNaStanje(kolicina);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Unesi naziv proizvoda i kolicinu koju zelis oduzet");
                            string naziv = Console.ReadLine();
                            int kolicina = int.Parse(Console.ReadLine());
                            if (skladiste.Proizvodi.Find(x => x.Naziv == naziv) != null)
                            {
                                skladiste.DohvatiProizvod(naziv).OduzmiSaStanja(kolicina);
                            }
                            break;
                        }
                    case 5:
                        {
                            foreach (var item in skladiste.Proizvodi)
                            {
                                Console.WriteLine($"Naziv{item.Naziv} Cijena:{item.JedinicnaCijena} Stanje:{item.Stanje} Vrijednost:{item.IzracunajVrijednostZaliha()}");
                            }
                            Console.WriteLine("Ukupna vrijednost zaliha:" + skladiste.IzracunajUkupnuVrijednostZaliha());
                            break;     
                        }
                    default:
                        break;
                }
            } while (izbor!=6);
        }
    }
}
