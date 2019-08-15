using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(TutorialsEntitiesNext tutorialEntities = new TutorialsEntitiesNext())
            {
                var outPara = new System.Data.Entity.Core.Objects.ObjectParameter("EmployeeId", typeof(string));
                var results =  tutorialEntities.spAddNewEmployee("Anand", "male", 50000, outPara);
                foreach (var item in tutorialEntities.Employees)
                {
                    Console.WriteLine(item.FirstName);
                } 
            }
            Console.ReadKey();
        }
    }
}
