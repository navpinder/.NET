using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class reverseWordsOfSentence
    {
        public void reverse()
        {
            Console.WriteLine("Enter the string:");
            string inputString = Convert.ToString(Console.ReadLine());
            string outputString = string.Join(" ", inputString.Split(' ').Reverse());
            Console.WriteLine("Output String is:");
            Console.WriteLine(outputString);
        }
    }
}
