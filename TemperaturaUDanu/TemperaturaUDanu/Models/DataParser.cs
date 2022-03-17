using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu.Models
{
    internal class DataParser
    {
        public List<double> Parse()
        {
            Sensor sensor = new Sensor();
            double[] refinedData = Array.ConvertAll(sensor.GetData().Split(';'), Double.Parse);
            List<double> data = new List<double>();
            data.AddRange(refinedData);
            return data;
        }
    }
}
