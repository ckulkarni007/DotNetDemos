using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDemo
{
    class WorldDbRepository
    {
        private WorldDbContext _worldDbContext;
        public WorldDbRepository(WorldDbContext worldDbContext)
        {
            _worldDbContext = worldDbContext;
        }

        public List<Country> GetCountries()
        {
            return _worldDbContext.Country.ToList();
        }


        public void InsertACountry(Country country)
        {
            _worldDbContext.Country.Add(country);
            _worldDbContext.SaveChanges();

        }

        public void UpdateCountryForId(int countryid, Country country)
        {
            _worldDbContext.Country.FirstOrDefault(c => c.Id.Equals(countryid)).Name = "test";
            _worldDbContext.SaveChanges();

        }



    }
}
