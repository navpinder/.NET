using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_08
{
    class Car
    {
        public void ColorCar(string color)
        {
            Console.WriteLine($"Car is of {color} color");
        }
    }
    class HatchBack : Car
    {
        public void HatchBackSize()
        {
            Console.WriteLine("Its Hatch back Car");
            Console.WriteLine("It is less then 4 meters");
        }
    }
    class Sedan : Car
    {
        public void SedanCarSize()
        {
            Console.WriteLine("Its Sedan Car");
            Console.WriteLine("It is larger then 4 meters");
        }
    }
    class SUV : Car
    {
        public void SUVSeat()
        {
            Console.WriteLine("Its SUV car");
            Console.WriteLine("It is 7 seaters");
        }
    }
}
