using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //firstBird fb = new firstBird();
            //Console.WriteLine("For first bird:");
            //fb.walk();
            //fb.fly();
            //secondBird sc = new secondBird();
            //Console.WriteLine("For second bird:");
            //sc.walk();
            //sc.sing();
            //add add = new add();
            //add.addition();
            //add.addition(3);
            //add.addition(1, 2);
            //add.addition(1, 2, 3);
            //add.addition(1, 2, 4, 6);
            //notification n;
            //Console.WriteLine("Enter 1 for sms and 2 for email:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x == 1)
            //{
            //    n = new sms();
            //    n.notify();
            //}
            //else if (x == 2)
            //{
            //    n = new email();
            //    n.notify();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            employee e;
            Console.WriteLine("Enter 1 for Manager and 2 for Clerk:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                e = new Manager("a","b");
                e.salary();
                e.display();
            }
            else if (x == 2)
            {
                e = new Clerk("z","v");
                e.salary();
                e.display();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
