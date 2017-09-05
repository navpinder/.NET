using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class longestWord
    {
        public void findLongestWord()
        {
            Console.WriteLine("Enter String:");
            string inputString = Convert.ToString(Console.ReadLine());
            var words = inputString.Split(' ');
            var finalOutput = words.OrderByDescending(n => n.Length).First();
            Console.WriteLine($"Word having longest length is: {finalOutput}");
        }
    }
}
