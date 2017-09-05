using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1108
{
    class removeVowels
    {
        public void PrintWordWithoutVowels()
        {
            Console.WriteLine("Enter Word:");
            StringBuilder word = new StringBuilder();
            string words = Convert.ToString(Console.ReadLine());
            foreach(char c in words)
            {
                if(c!='a' && c!='e' && c!='i' && c!='o' && c!='u')
                word.Append(c);
            }
            Console.WriteLine($"New Word is: {word}");
        }
    }
}
