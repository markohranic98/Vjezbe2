using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezbe2.Models;

namespace Vjezbe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcija = "";
            do
            {
                Console.WriteLine("1. dodavanje filma");
                Console.WriteLine("2. dodavanje glumca");
                Console.WriteLine("3. ispis filmova ");
                Console.WriteLine("4. ispis svih glumaca");
                Console.WriteLine("5. dodavanje glumca filmu");
                Console.WriteLine("6. pretraga filmova po glumcu");
                Console.WriteLine("x za izlaz");
                opcija = Console.ReadLine();

                switch (opcija)
                {
                    case "1":
                        {
                            Console.Write("Naslov filma: ");
                            string naslov = Console.ReadLine();
                            Console.Write("Godina filma: ");
                            int godina = int.Parse(Console.ReadLine());
                            Film noviFilm = new Film(naslov, godina);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Ime glumca: ");
                            string ime = Console.ReadLine();
                            Console.WriteLine("Prezime glumca : ");
                            string prezime = Console.ReadLine();
                            Glumac noviGlumac = new Glumac(ime, prezime);
                            break;
                        }
                    case "3":
                        {
                            foreach(Film item in Film.Filmovi)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "4":
                        {
                            foreach(Glumac item in Glumac.Glumci)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Unesite naziv filma: ");
                            string film = Console.ReadLine();
                            Film trazeniFilm = null;
                            foreach(Film item in Film.Filmovi)
                            {
                                if(item.Naslov.ToLower() == film.ToLower())
                                {
                                    trazeniFilm = item;
                                    break;
                                }
                            }

                            if(trazeniFilm == null)
                            {
                                Console.WriteLine("Ne postoji taj film");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Unesite prezime glumca: ");
                                string glumac = Console.ReadLine();
                                Glumac trazeniGlumac = null;
                                foreach (Glumac item in Glumac.Glumci)
                                {
                                    if(item.Prezime.ToLower() == glumac.ToLower())
                                    {
                                        trazeniGlumac = item;
                                        break;
                                    }
                                }
                                if(trazeniGlumac == null)
                                {
                                    Console.WriteLine("GLumca nema! ");
                                    break;

                                }
                                else
                                {
                                    trazeniFilm.DodajGLumca(trazeniGlumac);
                                }

                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Unesite ime glumca za pretragu: ");
                            string glumac = Console.ReadLine();
                            break;
                        }
                    default:
                        Console.WriteLine("Greska");
                        break;
                }
            } while (opcija != "x");
        }
    }
}
