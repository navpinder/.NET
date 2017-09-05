using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment_1808
{
    class ExtraSpace
    {
        public void RemoveExtraSpaces()
        {
            Console.WriteLine("Enter Input String:");
            string inputString = Convert.ToString(Console.ReadLine());
            string outputString = " ";
            string resultString = Regex.Replace(inputString, "\\s+", outputString);
            Console.WriteLine($"Output String is:\n{resultString}");
        }
    }
}
