using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedCSharp
{
    class NonGenericCollections
    {

        static void Main(string[] args)
        {
            ArrayList intArrayList = new ArrayList(12);
            Console.WriteLine(intArrayList.Capacity);
            intArrayList.Add(new Student("Chaitanya"));
            intArrayList.Add(new Student("Chaitanya"));
            intArrayList.Add(new Student("Chaitanya"));
            intArrayList.Add(new Student("Chaitanya"));
            Console.WriteLine(intArrayList.Capacity);
            intArrayList.Add(new Student("Chaitanya"));
            intArrayList.Add(new Student("Chaitanya"));
            Console.WriteLine(intArrayList.Capacity);

            //foreach (var item in intArrayList)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            int[] vs = { 1, 1 };
            IEnumerator enumerator = intArrayList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Student student = (Student)enumerator.Current;
                Console.WriteLine(student.ToString());
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