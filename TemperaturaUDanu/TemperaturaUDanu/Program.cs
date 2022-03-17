using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperaturaUDanu.Models;

namespace TemperaturaUDanu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature report:");
            Reporter reporter = new Reporter();
            DataParser parser = new DataParser();
            Console.WriteLine(reporter.GenerateReport(parser.Parse()));
            Console.ReadLine();
        }
    }
}
