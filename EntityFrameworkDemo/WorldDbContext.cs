using System.Data.Entity;

namespace EntityFrameworkDemo
{
    class WorldDbContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State{ get; set; }

    }
}
