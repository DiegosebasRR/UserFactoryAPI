using Microsoft.EntityFrameworkCore;

namespace UserFactoryAPI.Models
{
    public class FactoryDBContext : DbContext
    {
        public FactoryDBContext(DbContextOptions<FactoryDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
