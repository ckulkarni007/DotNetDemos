using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPDemo
{
    class Polymorphism
    {
        class Employee
        {
            public string name = "This is Employee";
            public string lastName;

            public void PrintName() { Console.WriteLine(name); }

            public virtual void PrintLastName() { Console.WriteLine("LastName"); }
        }

        class PartTimeEmployee : Employee
        {
            public string name = "This is Part Time Employee";
            public new void PrintName() { Console.WriteLine(name); }

            public override void PrintLastName() { Console.WriteLine("LastName- Child"); }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new PartTimeEmployee();
            employee.PrintName();
            employee.PrintLastName();
           // Console.WriteLine("Hello World!" + employee.name);
            Console.ReadKey();
        }
    }
}
