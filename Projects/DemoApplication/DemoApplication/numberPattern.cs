using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class numberPattern
    {
        public void printNumberPattern()
        {
            Console.WriteLine("Enter the no.of Rows:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l);
                }

                Console.WriteLine();
            }
        }
    }
}
