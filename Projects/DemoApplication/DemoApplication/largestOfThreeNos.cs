using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class largestOfThreeNos
    {
        public void findLargestOfThree()
        {
            Console.WriteLine("Enter 3 nos");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z)
                Console.WriteLine("The 1st Number is the greatest among three");
            else if (y > z)
                Console.WriteLine("The 2nd Number is the greatest among three");
            else
                Console.WriteLine("The 3rd Number is the greatest among three");
        }
    }
}
