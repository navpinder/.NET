using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class add
    {
        public void addition()
        {
            Console.WriteLine("No Parameters");
        }
        public void addition(int x)
        {
            Console.WriteLine("Only one Parameter ie" + x);
        }
        public void addition(int x, int y)
        {
            Console.WriteLine("Addition of 2 Parameters is " + (x + y));
        }
        public void addition(int x, int y, int z)
        {
            Console.WriteLine("Addition of 3 Parameters is " + (x + y + z));
        }
        public void addition(int x, int y, int z,int a)
        {
            Console.WriteLine("Addition of 4 Parameters is " + (x + y + z + a));
        }
    }
}
