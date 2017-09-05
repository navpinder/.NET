using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Question
            /*
            Console.WriteLine("Enter String:");
            string s = Convert.ToString(Console.ReadLine());
            string output_word = s.UppercaseFirstLetter();
            Console.WriteLine($"Output String is: {output_word}");
            */
            //2nd Question
            /*
            Console.WriteLine("Enter Color of Hatch Back Car:");
            string hatchColor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Color of Sedan Car:");
            string sedanColor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Color of SUV Car:");
            string SUVColor = Convert.ToString(Console.ReadLine());
            HatchBack hatchCar = new HatchBack();
            hatchCar.HatchBackSize();
            hatchCar.ColorCar(hatchColor);
            Sedan sedanCar = new Sedan();
            sedanCar.SedanCarSize();
            sedanCar.ColorCar(sedanColor);
            SUV suvCar = new SUV();            
            suvCar.SUVSeat();
            suvCar.ColorCar(SUVColor);
            */
            //3rd Question
            /*
            ICar iHatchObj = new HatchBackCar();
            iHatchObj.size();
            iHatchObj.color("Blue");
            ICar iSedanObj = new SedanCar();
            iSedanObj.size();
            iSedanObj.color("Red");
            */
            //4th  Question
            Console.WriteLine("Enetr Length:");
            float length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            float breadth= Convert.ToSingle(Console.ReadLine());
            Rectangle.Area(length, breadth);
            Console.ReadLine();
        }
    }
}
