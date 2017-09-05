using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    abstract class clsAbstract
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Aniaml can sound");
        }
    }
    class Dog : clsAbstract
    {
        public override void eat()
        {
            Console.WriteLine("dog can eat");
        }
    }
}
