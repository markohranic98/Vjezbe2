using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredlaganjeFilma.Models;
namespace PredlaganjeFilma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamingServis streaming = new StreamingServis();
            string odabir = "";
            do
            {
                Console.WriteLine("Zelite li prijedlog filma(da/ne)?");
                odabir = Console.ReadLine();
                if(odabir.ToLower() == "da")
                {
                    Console.WriteLine(streaming.PredloziFilm().DohvatiInfo()); 
                }
            } while (odabir != "ne");
        }
    }
}
