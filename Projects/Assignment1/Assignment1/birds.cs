using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class birds
    {
        public void walk()
        {
            Console.WriteLine("This Bird can walk");
        }
    }
    public class firstBird:birds
    {
        public void fly()
        {
            Console.WriteLine("This Bird can fly");
        }        
    }
    public class secondBird:birds
    {
        public void sing()
        {
            Console.WriteLine("This Bird can sing");
        }        
    }  
}
