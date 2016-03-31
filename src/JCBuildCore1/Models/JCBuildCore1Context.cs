using Microsoft.Data.Entity;

namespace JCBuildCore1.Models
{
    public class JCBuildCore1Context : DbContext
    {
        private static bool _created = false;

        public JCBuildCore1Context()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
