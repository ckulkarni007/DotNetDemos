using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net
{
    public class DataSets
    {

        public static void SQLDataAdapterUpdate()
        {
            
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from employees" , sqlConnection);
            DataSet dataSet = new DataSet();
            SqlCommand updateCommand = new SqlCommand("Update employees set  Salary = @Salary where ID = @ID", sqlConnection);
            updateCommand.Parameters.Add("@Salary", SqlDbType.Int, 0, "Salary");
            updateCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

            sqlDataAdapter.UpdateCommand = updateCommand;


            sqlDataAdapter.Fill(dataSet, "Employees");
            PrintTable(dataSet);
            dataSet.Tables["Employees"].Rows[1]["Salary"] = 10;
            dataSet.Tables["Employees"].Rows[1]["ID"] = 4;

            sqlDataAdapter.Update(dataSet, "Employees");
        }

        public static void SQLCommandBuilder()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from employees", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Employees");
            PrintTable(dataSet);

            DataTable empTable = dataSet.Tables["Employees"];

            var newRow = empTable.NewRow();
            newRow["ID"] = 22;
            newRow["FirstName"] = "Chaitnya";
            newRow["Salary"] = 15000;

            empTable.Rows.Add(newRow);

            //Update
            var rowToUpdate = dataSet.Tables["Employees"].AsEnumerable().FirstOrDefault(x => x["ID"].Equals(id));
            Console.WriteLine(rowToUpdate.RowState);
            rowToUpdate["FirstName"] = "This Is updated one new";
            Console.WriteLine(rowToUpdate.RowState);
            Console.ReadLine();
            sqlDataAdapter.Update(dataSet, "Employees");
        }



        public static void SQLReaderWithDataSetAndAdapter()
        {
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            DataSet dataSet = new DataSet();
            int id = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(connString);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select * from Employees where ID  =" + id, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlAdapter);

            sqlConnection.Open();
            sqlAdapter.Fill(dataSet, "Employees");
            sqlConnection.Close();
            // PrintTable(dataSet);

            var rowCollection = dataSet.Tables["Employees"].AsEnumerable();

            var rowTobeEdited = rowCollection.FirstOrDefault(x => x["ID"].Equals(2));
            Console.WriteLine(rowTobeEdited.RowState);

            rowTobeEdited["FirstName"] = "Tom";

            Console.WriteLine(sqlCommandBuilder.GetUpdateCommand().CommandText);

            //rowTobeEdited.RejectChanges();

            dataSet.AcceptChanges();



            sqlConnection.Open();
            int rowUpdated = sqlAdapter.Update(dataSet, "Employees");
            Console.WriteLine(rowUpdated);
            sqlConnection.Close();


        }

        private static DataSet CreateDataSetFromTable()
        {
            string connString = ConfigurationManager.ConnectionStrings["tutorialConnection"].ConnectionString;
            DataSet dataSet = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select * from Employees", sqlConnection);
                sqlConnection.Open();
                sqlAdapter.Fill(dataSet, "Employees");
            }

            return dataSet;
        }

        public static void PrintTable(DataSet dataSet)
        {
            DataTable empTable = dataSet.Tables["Employees"];
            Console.WriteLine(empTable.TableName);
            foreach (DataColumn column in empTable.Columns)
            {
                Console.Write(column.ColumnName + "\t\t");
            }

            foreach (DataRow row in empTable.Rows)
            {
                Console.WriteLine($"\n {row[empTable.Columns[0]]} \t\t {row[empTable.Columns[1]]} \t\t {row[empTable.Columns[2]]}");
            }
        }
    }
}
