using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples_1608
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 300000;
            int j = 200000;
            int k;
            try
            {
                k = checked(i * j);
            }
            catch (SystemException e)
            {
                Console.WriteLine($"Error caught {e.ToString()}");
            }
            if (i is int)
            {
                Console.WriteLine("i is an Object");
            }
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(typeof(Program));
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(float));
            Console.WriteLine(typeof(double));
            Console.WriteLine($"BODMAS {2*4/2+7}");
            object[] myObjects = new object[6];
            myObjects[0] = new A();
            myObjects[1] = new B();
            myObjects[2] = "string";
            myObjects[3] = 32;
            myObjects[4] = null;
            for(int a = 0; a < myObjects.Length; ++a)
            {
                int? s = myObjects[a] as int?;
                Console.WriteLine($"{a}");
                if(s!=null)
                    Console.WriteLine($"{s} is integer");
                else
                    Console.WriteLine("Not A INT");
            }
            int z=20;
            object o = z;
            int d = (int)o;
            Console.WriteLine($"{o}");
            Console.WriteLine($"{d}");
            A chkA = new A();
            A chkB = new A();
            chkA = chkB;
            bool B1 = ReferenceEquals(null, null);
            bool B2 = ReferenceEquals(null, chkA);
            bool B3 = ReferenceEquals(chkA, chkB);
            Console.WriteLine($"{B1} {B2} {B3}");
            A baseObject = new A();
            B derivedObject = new B();
            B derivedCopy1 = (B)derivedObject;
            derivedCopy1.print();
            //B derivedCopy2 = (B)baseObject;
            Console.ReadLine();
        }
    }
    public class A
    {

    }
    public class B:A
    {
        public void print()
        {
            Console.WriteLine("This is Derived Class");
        }
    }
}        
