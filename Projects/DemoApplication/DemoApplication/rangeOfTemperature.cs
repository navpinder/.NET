using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class rangeOfTemperature
    {
        public void findRangeOfTemp()
        {
            Console.WriteLine("Enter the Temperature in Degree Celcius");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
                Console.WriteLine("Freezing weather");
            else if(x>=0 && x<=10)
                Console.WriteLine("Very Cold weather");
            else if (x>10 && x<=20)
                Console.WriteLine("Cold weather");
            else if(x>20 && x<=30)
                Console.WriteLine("Normal in Temp");
            else if(x>30 && x<=40)
                Console.WriteLine("Its Hot");
            else
                Console.WriteLine("Its Very Hot");
        }
    }
}
