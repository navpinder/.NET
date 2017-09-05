using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class spaceNoSpacePattern
    {
        public void pattern()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 4; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(String.Join($"{num} ", new string[5]));
                }
                else
                {
                    Console.WriteLine(String.Join($"{num}", new string[5]));
                }
            }
        }
    }
}
