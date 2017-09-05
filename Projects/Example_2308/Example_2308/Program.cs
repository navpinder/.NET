using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Example_2308
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                student.SaveData();
                student.UpdateData();
                student.getDataSet();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();            
        }
    }
}
