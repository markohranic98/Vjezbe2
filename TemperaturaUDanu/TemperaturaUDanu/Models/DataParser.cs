using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu.Models
{
    internal class DataParser
    {
        public List<double> Parse(string sensorData)
        {
            Sensor sensor = new Sensor();
            double[] refinedData = Array.ConvertAll(sensor.GetData().Split(';'), Double.Parse);
            
            return ;
        }
    }
}
