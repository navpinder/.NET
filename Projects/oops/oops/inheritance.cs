using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class tyre
    {
        public void TyreType()
        {
            Console.WriteLine("Tubeless Tyre");
        }
    }
    public class Car:tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car is blue");
            TyreType();
        }
    }
    public class Scooter : tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter is blue");
            TyreType();
        }
    }
}
