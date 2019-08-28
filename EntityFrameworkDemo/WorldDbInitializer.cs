using System.Collections.Generic;
using System.Data.Entity;

namespace EntityFrameworkDemo
{
    class WorldDbInitializer : DropCreateDatabaseIfModelChanges<WorldDbContext>
    {
        protected override void Seed(WorldDbContext context)
        {
            context.Country.Add(new Country()
            {
                Currency = "Rupee",
                Name = "India",
                Population = 500000,
                States = new List<State>()
                {
                    new State {  Name = "Maharashtra" }
                }
            });
            context.SaveChanges();
        }
    }
}
