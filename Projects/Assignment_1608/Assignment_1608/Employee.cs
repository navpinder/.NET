using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1608
{
    class Employee
    {
        public List<Employee> listOfEmployee = new List<Employee>();
        public int ID;
            public string Name;
            public string DepartmentName;
            public string ProjectName;
        
        
        public Employee(int ID, string Name, string DepartmentName, string ProjectName)
        {
            this.ID = ID;
            this.Name = Name;
            this.DepartmentName =DepartmentName;
            this.ProjectName=ProjectName;
            listOfEmployee.Add(this);
        }
        Employee e1 = new Employee(1, "Navi", "IT", "ABC");
        Employee e2 = new Employee(1, "Nik", "IT", "ABC");
        Employee e3 = new Employee(1, "Nav", "MARKETING", "DEF");
        Employee e4 = new Employee(1, "Niki", "LOGISTICS", "DEF");
        Employee e5 = new Employee(1, "Navji", "HR", "XYZ");
        Employee e6 = new Employee(1, "Namo", "HR", "MNO");
        if(li
        {
            Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
        }
}
