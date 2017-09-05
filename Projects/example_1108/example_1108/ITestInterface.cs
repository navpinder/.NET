using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1108
{
    public interface ITestInterface
    {
        void GetName(string name);
        void CalculateBonus(int salary);
    }
    class Manager : ITestInterface
    {
        void ITestInterface.CalculateBonus(int salary)
        {
            double bonus = (double)salary * 0.25;
            Console.WriteLine($"Bonus of Manager is: Rs{bonus}");
        }

        void ITestInterface.GetName(string name)
        {            
            Console.WriteLine($"Name of Manager is: {name}");
        }
    }
    class Clerk : ITestInterface
    {
        void ITestInterface.CalculateBonus(int salary)
        {
            double bonus = (double)salary * 0.5;
            Console.WriteLine($"Bonus of Clerk is: Rs{bonus}");
        }

        void ITestInterface.GetName(string name)
        {
            Console.WriteLine($"Name of Clerk is: {name}");
        }
    }
}
