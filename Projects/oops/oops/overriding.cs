using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class BaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
