using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1108
{
    public static class Rectangle
    {
        public static void Area(double length,double breadth)
        {
            double area = length * breadth;
            Console.WriteLine($"Area is {area}");
        }
    }
}
