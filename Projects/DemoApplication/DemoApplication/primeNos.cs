using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class primeNos
    {

        public bool checkprime(double number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        public void findSum()
        {
            double sum = 0;
            int count = 0;
            for (double i = 2; count <= 1000; i++)
            {
                if (checkprime(i))
                {
                    sum = sum + i;
                    Console.WriteLine("Count {0} Number {1} ", count, i);
                    count++;

                }
            }
            Console.WriteLine("Sum of the First 500 prime numbers is {0} ", sum);
        }
    }//class ends

}
