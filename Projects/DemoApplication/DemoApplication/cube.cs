using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class cube
    {
        public void printCube()
        {
            Console.WriteLine("Input number of terms :");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is: {i} and cube of the {i} is : {cube}");
            }
        }
    }
}
