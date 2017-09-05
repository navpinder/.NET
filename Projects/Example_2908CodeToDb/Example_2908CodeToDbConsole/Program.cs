using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_2908CodeToDb;

namespace Example_2908CodeToDbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptobj = new Dapartment { DeptId = 1, Name = "IT", Location = "Pune" };
                dept.Departments.Add(deptobj);
                dept.SaveChanges();
                Console.WriteLine("Records Instered");
            }
            Console.ReadLine();
        }
    }
}
