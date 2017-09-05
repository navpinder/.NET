using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class NegativeNumber:Exception
    {
        public NegativeNumber(string message,string method_name) : base(method_name)
        {
            Console.WriteLine(message);
        }
    }
    public class NegativeNumberCheck
    {
        public void check(int num1,int num2,string method_name)
        {
            if(num1<0 || num2 < 0)
            {
                throw (new NegativeNumber("You Entered Negative Number", method_name));
            }
        }
    }
}
