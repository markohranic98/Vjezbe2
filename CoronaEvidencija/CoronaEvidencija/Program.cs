using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaEvidencija.Models;
namespace CoronaEvidencija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos = "";
            do
            {
                Console.WriteLine("1 za unos drzava i gradova");
                Console.WriteLine("2 za unos broja zarazenih ");
                Console.WriteLine("3 za ispis stanja zarazenih kroz vrijeme");
                Console.WriteLine("4 za van");
                unos = Console.ReadLine();

                switch (unos)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesi naziv drzave: ");
                            Drzava novaDrzava = new Drzava(Console.ReadLine());
                            novaDrzava.DodajGradove();
                            //novaDrzava.IspisGradova();
                            Console.ReadLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Unesi naziv drzave ");
                            string nazivDrzaveUnos = Console.ReadLine();
                            Drzava drzava = null;
                            drzava = Drzava.Drzave.Find(x => x.Naziv.ToLower().Equals(nazivDrzaveUnos.ToLower())); // ovo mozda nije bilo potrebno

                            if (drzava != null)
                            {
                                Console.WriteLine("Koji grad od ovih dolje zelis odabrati: ");
                                foreach (Grad item in drzava.Gradovi)
                                {
                                    Console.WriteLine("   "+item.NazivGrada);
                                }
                                string odabirGrada = Console.ReadLine();

                                Grad grad = drzava.Gradovi.Find(x=>x.NazivGrada.ToLower().Equals(odabirGrada.ToLower()));
                                grad.DodajKoronaZapise();

                            }
                            else
                            {
                                Console.WriteLine("Ne postoji ta drzava");
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Unesi naziv drzave ");
                            string nazivDrzaveUnos = Console.ReadLine();
                            Drzava drzava = null;
                            drzava = Drzava.Drzave.Find(x => x.Naziv.ToLower().Equals(nazivDrzaveUnos.ToLower())); // ovo mozda nije bilo potrebno

                            if (drzava != null)
                            {
                                Console.WriteLine("Koji grad od ovih dolje zelis odabrati: ");
                                foreach (Grad item in drzava.Gradovi)
                                {
                                    Console.WriteLine("   " + item.NazivGrada);
                                }
                                string odabirGrada = Console.ReadLine();

                                Grad grad = drzava.Gradovi.Find(x => x.NazivGrada.ToLower().Equals(odabirGrada.ToLower()));
                                grad.IspisiKoronaZapise();

                            }
                            else
                            {
                                Console.WriteLine("Ne postoji ta drzava");
                            }
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    default:
                        break;
                }
            } while (unos != "4");
        }
    }
}
