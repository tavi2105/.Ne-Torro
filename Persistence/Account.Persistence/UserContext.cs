using Microsoft.EntityFrameworkCore;
using Account.Persistence.Entities;

namespace Account.Persistence
{
    public class UserContext: DbContext
    {
        public UserContext( DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

    }
}
