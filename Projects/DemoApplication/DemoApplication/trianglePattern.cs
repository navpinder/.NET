using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class trianglePattern
    {
        public void printPattern()
        {
            Console.WriteLine("Enter Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width");
            int y = Convert.ToInt32(Console.ReadLine());
            for(int i = y; i >= 1; i--)
            {
                Console.WriteLine(String.Join($"{x} ", new string[i+1]));             
            }
        }
    }
}
