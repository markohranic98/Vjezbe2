using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mjenjacnica.Models;

namespace Mjenjacnica
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            MjenjacnicaClass mjenjacnica = new MjenjacnicaClass();
            double iznos = 0;
            string unosOdredisnaValuta = "";
            Console.Write("Unesi iznos koji zelis promijenit: ");
            iznos = double.Parse(Console.ReadLine());
            Console.Write("Unesi odredisnu valutu: ");
            unosOdredisnaValuta = Console.ReadLine();

            mjenjacnica.IspisPotvrde(mjenjacnica.PromijeniNovac(iznos, unosOdredisnaValuta));

            Console.ReadLine();
        }
    }
}
