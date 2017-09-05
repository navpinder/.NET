using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2208
{
    class Program
    {
        public void division(int n1, int n2)
        {
            int result=0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught {e}");
            }
            finally
            {
                Console.WriteLine($"Result is {result}");
            }
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.division(5, 0);
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch(tempZero e)
            {
                Console.WriteLine($"{e}");
            }
            Console.ReadLine();
        }
    }
}
