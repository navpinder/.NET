using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_08
{
    public static class Rectangle
    {
        public static void Area(float length, float breadth)
        {
            float area = length * breadth;
            Console.WriteLine($"Area is {area}");
        }
    }
}
