using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1608
{
    class Program
    {
        public delegate int CalculateSimpleInterest(int rate, int year, int principle);
        public int getTotalInterest(int rate,int principle,int year)
        {
            return ((rate * principle * year) / 100);
        }
        public int getInterestRatePerYear(int priciple,int year,int interest)
        {
            return (int)((interest*100)/(priciple*year));
        }
        public static void CallDelegat(Program p)
        {
            //Func<int, int, int, int> CalculateSimpleInterest = new Func<int, int, int, int>(p.getTotalInterest);//using func
            /*CalculateSimpleInterest si = delegate (int rate, int year, int principle)//Anonymous 
            {
                 Console.WriteLine((rate * year * principle) / 100);
                 Console.ReadLine();
             };*/
            //si(6, 6000, 2);
            //Console.WriteLine(CalculateSimpleInterest(6, 6000, 2));//for func
            CalculateSimpleInterest si = (rate, year, principle) =>
              {
                  Console.WriteLine((rate * year * principle) / 100);
                  return 0;
              };
            CalculateSimpleInterest s = new CalculateSimpleInterest(p.getInterestRatePerYear);//multicast
            Console.WriteLine(s(60000, 1, 6000));
            Console.ReadLine(); 
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            CallDelegat(p);
        }
    }
}
