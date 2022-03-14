using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelskaSoba.Models;

namespace HotelskaSoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            string naredba = "";
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                naredba = Console.ReadLine();

                switch (naredba)
                {
                    case string a when a.StartsWith("#pronadji"):
                        {
                            List<Soba> listSoba = hotel.PronadjiSobe(int.Parse(a.Substring(10)));
                            foreach (Soba item in listSoba)
                            {
                                Console.WriteLine(item.Oznaka);
                            }
                            break;
                        }
                    case string a when a.StartsWith("#rezerviraj"):
                        {
                            hotel.RezervirajSobu(a.Substring(12));
                            break;
                        }
                    case "#exit":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Kriva naredba");
                            break;
                        }

                }
            } while (naredba!="exit");
            Console.Read();
        }
    }
}
