using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2208
{
    public class tempZero:Exception
    {
        public tempZero(string message) : base(message)
        {
        }
    }
    public class Temperature
    {
        int temp = 0;
        public void showTemp()
        {
            if (temp == 0)
            {
                throw (new tempZero("Zero Temp Found"));
            }
            else
            {
                Console.WriteLine($"{temp}");
            }
        }
    }
}