using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class sumOfDigits
    {
        public void additionOfDigits()
        {
            int sum = 0;
            Console.WriteLine("Enter the digit");
            int x = Convert.ToInt32(Console.ReadLine());
            do
            {
                int y = x % 10;
                x = x / 10;
                sum = sum + y;
            } while (x > 0);
            Console.WriteLine($"Addition of digits is {sum}");
        }
    }
}
