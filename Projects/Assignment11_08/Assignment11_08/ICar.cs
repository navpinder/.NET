using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_08
{
    interface ICar
    {
        void color(string color);
        void size();
    }
    class HatchBackCar : ICar
    {
        public void color(string color)
        {
            Console.WriteLine($"Color of car is: {color}");
        }
        public void size()
        {
            Console.WriteLine("Its Hatch back Car");
            Console.WriteLine("It is less then 4 meters");
        }
    }
    class SedanCar : ICar
    {
        public void color(string color)
        {
            Console.WriteLine($"Color of car is: {color}");
        }
        public void size()
        {
            Console.WriteLine("Its Sedan Car");
            Console.WriteLine("It is larger then 4 meters");
        }
    }
}
