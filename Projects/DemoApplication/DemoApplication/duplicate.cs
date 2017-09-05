using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class duplicate
    {
        public void eliminate()
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            var characters = s.Split(' ').Distinct();
            string new_string = String.Join(" ", characters);
            Console.WriteLine("{0}",new_string);
        }
    }
}
