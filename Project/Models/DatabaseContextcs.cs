using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Home> home { get; set; }

        public DbSet<Country> Countries {  get; set; }
    }
}
