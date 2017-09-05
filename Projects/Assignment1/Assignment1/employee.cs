using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class employee
    {
        string name, position;
        public int sal;
        //public employee() { }
        public employee(string name, string position)
        {
            this.name = name;
            this.position = position;
        }
        public abstract void salary();
        public void display()
        {
            Console.WriteLine("Name of Employee is " + name);
            Console.WriteLine("Position of Employee is "+position);
            Console.WriteLine("Salart is " + sal);
        }
    }
    class Manager : employee
    {
        public Manager(string name, string position) : base(name, position)
        {
        }

        public override void salary()
        {
            sal = 5000;
        }
    }
    class Clerk : employee
    {
        public Clerk(string name, string position) : base(name, position)
        {
        }

        public override void salary()
        {
            sal = 500;
        }
    }
}
