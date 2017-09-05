using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class palindrome
    {
        public void chk()
        {
            string r = "";
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r+= s[i].ToString();
            }
            if (s == r)
            {
                Console.WriteLine("{0} and {1} are palindrome", s, r);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not a palindrome", s, r);
            }
        }
    }
}
