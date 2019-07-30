using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPDemo
{
    class Inheritance
    {
        static void Main(string[] args)
        {

        }
    }

    public class Employee
    {
       
        public string Age;

        public virtual float PrintName(string name)
        {
            Console.WriteLine(name);
            return 0.0F;
        }
    }
    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name)
        {

        }

    }
}
