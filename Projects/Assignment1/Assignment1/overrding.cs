using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class notification
    {
        public virtual void notify()
        {
            //Console.WriteLine("hgfjhgkhlhlj");
        }
    }
    public class sms : notification
    {
        public override void notify()
        {
            Console.WriteLine("You will be notified by sms");
        }
    }
    public class email : notification
    {
        public override void notify()
        {
            Console.WriteLine("You will be notified by email");
        }
    }
}
