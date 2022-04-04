using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    public static class TemperatureConverter
    {
        public static double fahrenheitToCelsius(double temp)
        {
            double celsius = (temp - 32) * 5 / 9; // convert temp to celsius
            return celsius;
        }
    }
}
