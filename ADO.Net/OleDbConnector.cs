using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ADO.Net
{
    public class OleDbConnector
    {
        public static void CreateOleConnection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckulkarni\\Documents\\TutorialsTest.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("select * from employees",oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
            oleDbConnection.Close();
            Console.ReadLine();
        }

        public static void InsetInOleDB()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckulkarni\\Documents\\TutorialsTest.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("Insert into Employees values ( 5,'John', 80000)", oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteNonQuery();
            Console.WriteLine(reader);
            oleDbConnection.Close();
            Console.ReadLine();
        }
    }
}
