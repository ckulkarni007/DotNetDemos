using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Database.SetInitializer(new WorldDbInitializer());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WorldDbContext>());
            WorldDbRepository worldDbRepository = new WorldDbRepository(new WorldDbContext());
            var country = new Country()
            {
                Currency = "Rupee",
                Name = "India",
                Population = 500000,
                States = new List<State>()
                {
                    new State {  Name = "Maharashtra" }
                }
            };
            worldDbRepository.InsertACountry(country);
            worldDbRepository.UpdateCountryForId(1, null);
            var countries = worldDbRepository.GetCountries();
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }

        private static void StoredProcedure()
        {
            using (TutorialsEntitiesNext tutorialEntities = new TutorialsEntitiesNext())
            {
                var outPara = new System.Data.Entity.Core.Objects.ObjectParameter("EmployeeId", typeof(string));
                var results = tutorialEntities.spAddNewEmployee("Anand", "male", 50000, outPara);
                foreach (var item in tutorialEntities.Employees)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }
    }
}
