using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net
{
    class StoredProcedure
    {
        public static void StoredProc()
        {
            //Read the connection string from Web.Config file
            string ConnectionString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                //Create the SqlCommand object
                SqlCommand cmd = new SqlCommand("spAddNewEmployee", con);
                //Specify that the SqlCommand is a stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add the input parameters to the command object
                cmd.Parameters.AddWithValue("@Name", "Harvey");
                cmd.Parameters.AddWithValue("@Gender", "male");
                cmd.Parameters.AddWithValue("@Salary", 30000000);

                //Add the output parameter to the command object
                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@EmployeeId";
                outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outPutParameter);

                //Open the connection and execute the query
                con.Open();
                cmd.ExecuteNonQuery();

                //Retrieve the value of the output parameter
                string EmployeeId = outPutParameter.Value.ToString();
                Console.WriteLine(EmployeeId);
            }
        }
    }
}
