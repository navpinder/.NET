using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class binaryConversion
    {
        public void findBinary()
        {
            Console.WriteLine("Enter Decimal Number");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            Console.WriteLine($"Binary Number is: {binary}");
        }
    }
}
