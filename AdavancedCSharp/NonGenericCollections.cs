using System;
using System.Collections;
using System.Collections.Generic;

namespace AdavancedCSharp
{
    class NonGenericCollections
    {

        public bool IsNameMatch(string name)
        {
            return name.Equals("testt0");
        }

        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();


            studentNames.Add("Jayashree");
            studentNames.Add("Chaitanya");
            studentNames.Add("Akshay");
            studentNames.Add("Priyanka");


            foreach (var item in studentNames)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

    }

    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return this.Name;
        }

        public bool IsLessThan(int Id)
        {
            return this.Id < Id;
        }
    }

}