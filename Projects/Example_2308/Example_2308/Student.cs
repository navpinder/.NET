using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Example_2308
{
    public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery;

        public Student()
        {
            sqlHelper = new SqlHelper();
        }
        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt= sqlHelper.GetDataSet(sqlQuery);
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll No: {0}\nName: {1}", dr[0], dr[1]));
            }
            dt.WriteXml("student.xls");
        }        
        public void GetData()
        {
            sqlQuery = "select * from [Table]";
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);
            while(sqlReader.Read())
            {
                Console.WriteLine(string.Format("Roll No: {0}\nName: {1}",sqlReader[0],sqlReader[1]));
            }
            sqlReader.Close();
            sqlQuery = "select count(*) from [Table]";
            var count = sqlHelper.ExecuteQueryScalar(sqlQuery);
            Console.WriteLine($"Count {count}");            
        }
        public void SaveData()
        {
            Console.WriteLine("Enter Roll No");
            int rno = Convert.ToInt32(Console.ReadLine());
            sqlQuery = string.Format(@"insert into [table] values" + "({0},'{1}',{2},'{3}')", rno, "Ram", 42, "1234567890");
            sqlHelper.ExecuteNonQuery(sqlQuery);
        }
        public void UpdateData()
        {
            Console.WriteLine("Enter Roll No Whose Name is to Updated");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Name");
            string name = Convert.ToString(Console.ReadLine());
            sqlHelper.update(rno,name);
        }
    }
}
