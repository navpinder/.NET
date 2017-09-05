using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment_1808
{
    class NumberCheck
    {
        public void CheckNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            string number = Convert.ToString(Console.ReadLine());
            Regex regex = new Regex(@"^\d{3}-\d{4}$");
            Match match = regex.Match($"{number}");
            if (match.Success)
            {
                Console.WriteLine("Number is in Right Format");
            }
            else
            {
                Console.WriteLine("Number is not in Right Format");
            }
        }
    }
}
