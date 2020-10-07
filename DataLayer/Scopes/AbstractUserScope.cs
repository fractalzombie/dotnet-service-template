using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Scopes
{
    public abstract class AbstractUserScope: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected AbstractUserScope(DbContextOptions options) : base(options)
        {
        }
    }
}
