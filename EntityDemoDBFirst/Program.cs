using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemoDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Insert();
            var empCollection =  Get();
            foreach (var item in empCollection)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadKey();
        }

        public static void Insert()
        {
            using(tutorialsEntitiesNew entities = new tutorialsEntitiesNew())
            {
                entities.Employees.Add(new Employee() { FirstName = "Jayashree", Salary = 500000 });
                entities.SaveChanges();
            }
        }

        public static List<Employee> Get()
        {
            using (tutorialsEntitiesNew entities = new tutorialsEntitiesNew())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
