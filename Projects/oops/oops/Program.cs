using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract
            Dog dd = new Dog();
            //clsAbstract thePet = dd;
            dd.eat();
            dd.sound();         
            Scooter sc = new Scooter();
            sc.ScooterType();
            calculator c = new calculator();
            c.sum();
            c.sum(3);
            c.sum(4, 5);
            DerivedClass dc = new DerivedClass();
            BaseClass bc = dc;
            bc.MyMethod();            
            dc.MyMethod();
            Console.ReadLine();
        }
    }
}
