using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class bill
    {
        public void calculateBill()
        {
            double amountOfUnits, surcharge=0,totalBill,rateOfUnit;
            Console.WriteLine("Enter Customer id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of Customer:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Unit:");
            int units = Convert.ToInt32(Console.ReadLine());
            if (units <= 199)
            {
                rateOfUnit = 1.2;
                amountOfUnits = units * rateOfUnit;
            }
                
            else if (units >= 200 && units < 400)
            {
                rateOfUnit=1.5;
                amountOfUnits = units * rateOfUnit;
            }
                
            else if (units >= 400 && units < 600)
            {
                rateOfUnit = 1.8;
                amountOfUnits = units * rateOfUnit;
            }

            else
            {
                rateOfUnit = 2;
                amountOfUnits = units * rateOfUnit;
            }
               
            if (amountOfUnits >= 400)
            {
                surcharge = 0.15 * amountOfUnits;                
            }
            totalBill = amountOfUnits + surcharge;
            Console.WriteLine($"Customer ID: {id}");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Units Consumed: {units}");            
            if (totalBill > 100)
            {
                Console.WriteLine($"Amount Charges @Rs. {rateOfUnit} per unit: {amountOfUnits}");
                Console.WriteLine($"Surcharge Amount: {surcharge}");
                Console.WriteLine($"Net Amount Paid By Customer: {totalBill}");
            }
            else
            {
                Console.WriteLine("Your Total Amount is less 100!");
            }
        }
    }
}
