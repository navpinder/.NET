using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_2908;

namespace Example_2908Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeesEntities())
            {
                //var emp = new emp();
                //emp.Empid = 1;
                //emp.Name = "Navi";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //emp = new emp();
                //emp.Empid = 2;
                //emp.Name = "Nav";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //emp = new emp();
                //emp.Empid = 3;
                //emp.Name = "Navpi";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //EmpObj.SaveChanges();
                emp empUpdateObj = EmpObj.emps.First(i => i.Empid == 2);//update
                empUpdateObj.Name = "Nik";
                empUpdateObj.Salary = 41000;
                EmpObj.SaveChanges();
                emp empDelete = EmpObj.emps.First(i => i.Empid == 2);//delete
                EmpObj.emps.Remove(empDelete);
                EmpObj.SaveChanges();
                Console.WriteLine("Records inserted");
            }
        }
    }
}
