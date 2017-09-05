using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class diamondPattern
    {
        public void printPattern()
        {
            Console.WriteLine("Enter the nos.of row:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = num - 1;
            for(int i = 1; i <= num; i++)
            {
                Console.Write(String.Join(" ", new string[count+1]));
                Console.WriteLine(String.Join("*", new string[(2*i)]));
                count--;
            }
            count = 1;
            for(int i = 1; i < num; i++)
            {
                Console.Write(String.Join(" ", new string[count + 1]));
                Console.WriteLine(String.Join("*", new string[(2 * (num-i))]));
                count++;
            }
        }
    }
}
