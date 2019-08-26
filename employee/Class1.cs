using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Class1
    {
        public delegate void SomeDelegate(string a,string b);
        public static int id = 02;
        public static  string gh="pooja";
        public static string hgh = "kokate";
        public static float salary = 2500;

        public static void PrintFullName(string firstname, string lastName)
        {
            Console.WriteLine(firstname + lastName);
        }

        public static void PrintCommaseparatedFullName(string firstname, string lastName)
        {
            Console.WriteLine(firstname +","+ lastName);
        }

       

        static new void Main()
        {
            SomeDelegate someDelegate = new SomeDelegate(PrintFullName);
            someDelegate += PrintCommaseparatedFullName;

            Console.ReadLine();
        }
    }
}
