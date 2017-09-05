using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exception_Handling
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int ans = 0;
            int num1 = 0;
            int num2=0;
            string method_name= MethodBase.GetCurrentMethod().Name;
            MathLib.Class1 obj = new MathLib.Class1();
            try
            {
                MathLib.Class1 obj1 = null;       //NullReferenceException
                obj1.add(5, 4);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception");
                Console.WriteLine($"Exception: {e}");
            }
            try
            {
                object test = obj;
                StreamReader reader = (StreamReader)test;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Invalid Cast Exception");
                Console.WriteLine($"Exception: {e}");
            }
            Console.WriteLine("Enter\n1. For Addition\n2. For Subtraction\n3. For Mulitplication\n4. For Division");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Number:");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Integer Expected");
                Console.WriteLine($"Exception: {e}");
                //System.Environment.Exit(1);
            }
            Console.WriteLine("Enter Second Number");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Integer Expected");
                Console.WriteLine($"Exception: {e}");
            }
            try
            {
                NegativeNumberCheck chk = new NegativeNumberCheck();
                chk.check(num1, num2, method_name);
            }
            catch(NegativeNumber e)
            {
                Console.WriteLine($"{e}");
            }
            switch (option)
            {
                case 1:
                    ans = obj.add(num1, num2);
                    break;
                case 2:
                    ans = obj.subtract(num1, num2);
                    break;
                case 3:
                    ans = obj.multiply(num1, num2);
                    break;
                case 4:
                    ans = obj.divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("You Entered A Wrong Command!!");
                    break;
            }
            Console.WriteLine($"Answer is : {ans}");
            Console.ReadLine();
        }
    }
}
