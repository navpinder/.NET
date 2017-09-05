using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class calculator
    {
        public void menuDriven()
        {
            double ans;
            Console.WriteLine("Enter first Integer:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second Integer:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Here Are Your Options:");
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");
            int z= Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    ans = x + y;
                    Console.WriteLine($"Addition of {x} and {y} is {ans}");
                    break;
                case 2:
                    ans = x - y;
                    Console.WriteLine($"Subtraction of {x} and {y} is {ans}");
                    break;
                case 3:
                    ans = x * y;
                    Console.WriteLine($"Multiplication of {x} and {y} is {ans}");
                    break;
                case 4:
                    ans = x / y;
                    Console.WriteLine($"Division of {x} and {y} is {ans}");
                    break;
                case 5:
                    Console.WriteLine("You have exited successfully");
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Command");
                    break;
            }
        }
    }
}
