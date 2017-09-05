using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class degree
    {
        public void convertCelciusToFahrenheit()
        {
            Console.WriteLine("Enter temperature in Celcius:");
            double c=Convert.ToDouble(Console.ReadLine());
            double f = (c * 1.8) + 32;
            Console.WriteLine($"Temperature in Fahrenheit is {f}F");
        }
    }
}
