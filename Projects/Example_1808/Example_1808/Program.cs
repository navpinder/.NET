using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1808
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ExapmeList = new List<string>();
            ExapmeList.Add("Sam");
            ExapmeList.Add("Sunil");
            ExapmeList.Add("Nav");
            foreach(var Item in ExapmeList)
            {
                Console.WriteLine(Item);
            }
            Console.ReadLine();
        }
    }
}
