using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Example_2308
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        public string sqlQuery=null;
        public string conString = @"Data Source=NAVAPINDER-S;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False";

        public SqlHelper()
        {
            sqlConnection = new SqlConnection(conString);
            if(sqlConnection.State==System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            Console.WriteLine("Connection is open");

        }
        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            sqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];
        }
        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
            return sqlCommand.ExecuteReader();
        }
        public string ExecuteQueryScalar(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
            return sqlCommand.ExecuteScalar().ToString();
        }
        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            sqlCommand = new SqlCommand(sql, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }
        public void update(int rno, string name)
        {
            var ds = new DataSet();
            sqlQuery = "update [Table] set StudName= '"+name+"' where Rno= "+rno;
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            sqlDataAdapter.Fill(ds, "student");
        }

    }
}
