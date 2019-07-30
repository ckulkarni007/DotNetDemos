using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Employee
    {
        private string _name;
        private int _age;
        public Employee() : this("Arsene", 20)
        {
        }
        public Employee(string name, int age)
        {
            _name = name;
            _age = age;
        }
        ~Employee()
        {

        }
    }

    class Classes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new Employee();
            Student student = new Student();
            Console.ReadKey();
        }
    }


    public partial class Student
    {
        public string GetName()
        {
            return "Arsene Wenger";
        }
    public string Name { get; set; }
    public Subject[] MyProperty { get; set; }
}

public class Subject
{
    public string Name { get; set; }

    public string GetName()
    {
        throw new Exception("This has been thrown by me not by system");
    }
}

public partial class Student
    {
        public int GetAge()
        {
            return 18;
        }
    }

