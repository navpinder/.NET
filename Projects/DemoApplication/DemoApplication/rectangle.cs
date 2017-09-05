using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class rectangle
    {
        public void printPattern()
        {
            Console.WriteLine("Enter Number");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 5; i++)
            {
                if (i == 1 || i == 5)
                {
                    Console.WriteLine(String.Join($"{x}", new string[4]));
                }
                else
                {
                    Console.WriteLine(String.Join($"{x} {x}", new string[2]));
                }
            }
        }
    }
}
