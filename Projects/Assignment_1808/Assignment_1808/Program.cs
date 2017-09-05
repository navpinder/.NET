using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1808
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberCheck check = new NumberCheck();
            //check.CheckNumber();
            //ExtraSpace spaces = new ExtraSpace();
            //spaces.RemoveExtraSpaces();
            //Collection collections = new Collection();
            //collections.ExampleOfCollections();
            List<EmployeeGenericCollection> emp = new List<EmployeeGenericCollection>();
            emp.Add(new EmployeeGenericCollection(700, "Anil", 5000));
            emp.Add(new EmployeeGenericCollection(600, "Sunil", 6000));
            emp.Add(new EmployeeGenericCollection(500, "Ram", 5000));
            emp.Add(new EmployeeGenericCollection(400, "Shyam", 6000));

            foreach (var e in emp)
            {
                Console.WriteLine(e.empCode + "," + e.name + "," + e.salary);
            }

            emp.Sort();
            Console.WriteLine("\nAfter sorting based on Employee Code");
            foreach (var e in emp)
            {
                Console.WriteLine(e.empCode + "," + e.name + "," + e.salary);
            }

            Console.ReadKey();
        }
    }
}
