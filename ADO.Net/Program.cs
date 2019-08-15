using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            LINQTOSQLEntities.RetrieveEmployeeDetails();
            Console.ReadKey();
        }

        public static void ReadDataUsingDisconnectedMode()
        {
            SqlConnection sqlConnection = new SqlConnection("data source = (local); database=tutorials; integrated security =SSPI");

            DataSet employeeState = new DataSet();
            SqlCommand sqlCommand = new SqlCommand("select * from employees");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand.CommandText, sqlConnection);
            sqlDataAdapter.Fill(employeeState, "Employees");

            DataSets.PrintTable(employeeState);


        }



        private static void SqlDataSetAdapters()
        {
            SqlConnection sqlConnection = new SqlConnection("data source = (local); database=tutorials; integrated security =SSPI");

            DataSet dataSet = new DataSet();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from employees", sqlConnection);

            sqlDataAdapter.Fill(dataSet);
        }

        private static void SQLConnectionWithSqlReader()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = (local); database=tutorials; integrated security =SSPI";
            string userName = Console.ReadLine();
            SqlCommand sqlCommand = new SqlCommand("select * from employees where FirstName = @FirstName and Id = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FirstName", userName);
            sqlCommand.Parameters.AddWithValue("@ID", 2);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader[4]);
            }
            sqlConnection.Close();
        }

        private static void SQLConnectionWithSqlReaderWithMultipleData()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = (local); database=tutorials; integrated security =SSPI";
            SqlCommand sqlCommand = new SqlCommand("select * from employees; select * from departments;", sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

           
            while (sqlDataReader.NextResult())
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine((string)sqlDataReader[0] + (string)sqlDataReader[1] + (string)sqlDataReader[2]);
                }
            }
            sqlConnection.Close();
        }

        private static void SQLScalerWithAppConfig()
        {
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("select Count(*) from employees", sqlConnection);
                sqlConnection.Open();

                int count = (int)sqlCommand.ExecuteScalar();

                Console.WriteLine($"The total count of employees - {count}");
            }
        }

        private static void ExecuteNonQueryCommand()
        {
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("update Employees set  Salary = @Salary where FirstName = 'Ben'", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Salary", 300);
                sqlConnection.Open();
                int count = (int)sqlCommand.ExecuteNonQuery();
                Console.WriteLine($"The total employees added - {count}");
            }
        }

        //SQL Reader with Params
        private static void SQLConnectionWithSqlReaderParams()
        {
            SqlDataReader sqlDataReader = null;
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                //SqlCommand sqlCommand = new SqlCommand("Select * from Employees where FirstName like '" + Console.ReadLine() + "%'", sqlConnection);
                var input = Console.ReadLine();
                SqlCommand sqlCommandWithParam = new SqlCommand("Select * from Employees where FirstName like @FirstName", sqlConnection);
                sqlCommandWithParam.Parameters.AddWithValue("@FirstName", input);
                sqlConnection.Open();
                sqlDataReader = sqlCommandWithParam.ExecuteReader();
                if (sqlDataReader.IsClosed) ;
                
            }

            while (!sqlDataReader.IsClosed &&  sqlDataReader.Read())
            {
                Console.WriteLine((string)sqlDataReader[1]);
            }
        }


        //SQL Reader with Params
        private static void SQLReaderWithDataTable()
        {
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand("Select * from Employees", sqlConnection);
               
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("FirstName");
                dataTable.Columns.Add("Salary");
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataTable.Rows.Add(sqlDataReader["ID"], sqlDataReader["FirstName"], sqlDataReader["Salary"]);
                }
            }
            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine(item["Id"].ToString());
                Console.WriteLine(item["FirstName"].ToString());
                Console.WriteLine(item["Salary"].ToString());
            }
        }

        
    }
}
