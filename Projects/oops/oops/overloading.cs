using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class calculator
    {
        public void sum()
        {
            Console.WriteLine("No Parameters");
        }
        public void sum(int x)
        {
            Console.WriteLine("One Parameter "+x);
        }
        public void sum(int x,int y)
        {
            Console.WriteLine("2 Parameters "+(x+y));
        }
    }
}
