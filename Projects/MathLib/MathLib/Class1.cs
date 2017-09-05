using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Class1
    {
        int ans;
        public int add(int number1,int number2)
        {
            ans = number1 + number2;
            return ans;
        }
        public int subtract(int number1,int number2)
        { 
            ans = number1 - number2;
            return ans;
        }
        public int multiply(int number1,int number2)
        {
            ans = number1 * number2;
            return ans;
        }
        public int divide(int number1,int number2)
        {
            try
            {
                ans = number1 / number2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Exception: {e}");
            }
            return ans;
        }
    }
}
