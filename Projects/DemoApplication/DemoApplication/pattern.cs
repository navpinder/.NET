using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class pattern
    {
        public void star()
        {
            //for (int i = 1; i <= x; i++)
            //{
            //    for(int j = 1; j <= x; j++)
            //    {
            //        if (j <= (x - i))
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }                    
            //    }
            //   Console.WriteLine();
            //}
            Console.WriteLine("Enter the no.of lines for pattern ");
            int x = Convert.ToInt32(Console.ReadLine());
            int row = 1;
            print:
            for(int i = 1; i <= x; i++)
            {
                if (i <= x - row)
                {
                    Console.Write(" ");
                    continue;
                }
                else
                {
                    Console.Write("*");
                }                
            }
            Console.WriteLine();
            row++;
            if (row != x)
            goto print;
        }
    }
}
