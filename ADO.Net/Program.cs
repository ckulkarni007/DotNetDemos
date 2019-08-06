using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //SQLConnectionWithSqlReader();

            SqlConnection sqlConnection = new SqlConnection("data source = (local); database=tutorials; integrated security =SSPI");

            DataSet dataSet = new DataSet();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from employees", sqlConnection);

            sqlDataAdapter.Fill(dataSet);

            Console.ReadKey();
        }

        private static void SQLConnectionWithSqlReader()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = (local); database=tutorials; integrated security =SSPI";

            SqlCommand sqlCommand = new SqlCommand("select * from employees", sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine((string)sqlDataReader[1]);
            }
            sqlConnection.Close();
        }
    }
}
