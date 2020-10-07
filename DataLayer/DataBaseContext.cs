using DataLayer.Entities;
using DataLayer.Scopes;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    internal sealed class DataBaseContext : AbstractUserScope
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.ApplyConfigurationsFromAssembly(assembly: typeof(DataBaseContext).Assembly);
        }
    }
}
