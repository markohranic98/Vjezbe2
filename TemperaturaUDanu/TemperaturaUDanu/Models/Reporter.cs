using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu.Models
{
    internal class Reporter
    {
        private double GetMinimalTemperature(List<double> data)
        {
            return data.Min(x => x);
        }

        private double GetMaximalTemperature(List<double> data)
        {
            return data.Max(x => x);
        }

        private double GetAverageTemperature(List<double> data)
        {
            return data.Average(x => x);
        }

        public string GenerateReport(List<double> data)
        {
            return $"Average temperature is {GetAverageTemperature(data)} *C, minimal temperature is {GetMinimalTemperature(data)} *C, macimal temperature is {GetMaximalTemperature(data)} *C";
        }
    }
}
