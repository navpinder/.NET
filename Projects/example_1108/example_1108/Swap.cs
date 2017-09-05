using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1108
{
    class Swap
    {
        public void SwapTwoNos(double a,double b)
        {
            double temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Value of a after swapping is {a}");
            Console.WriteLine($"Value of b after swapping is {b}");
        }
    }
}
