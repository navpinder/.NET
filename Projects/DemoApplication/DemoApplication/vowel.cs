using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class vowel
    {
        public void chkVowelOrNot()
        {
            Console.WriteLine("Enter the Character");
            char x = Convert.ToChar(Console.ReadLine());
            if(x=='a' || x=='e' || x=='i' || x=='o' || x=='u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
                Console.WriteLine("The Alphabet is vowel");
            else
                Console.WriteLine("The Alphabet is constant");
        }
    }
}
