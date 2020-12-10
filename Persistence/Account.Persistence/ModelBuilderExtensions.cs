using Microsoft.EntityFrameworkCore;
using Account.Persistence.Entities;

namespace Account.Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "ioanvalentincernovschi@gmail.com", Password = "tavi", FirstName = "Ioan", LastName = "Cernovschi", PhoneNumber = "0700000000"},
                new User { Id = 2, Email = "tavi22015@gmail.com", Password = "john", FirstName = "Octavian", LastName = "Ungureanu", PhoneNumber = "0700000001"},
                new User { Id = 3, Email = "mihneav@gmail.com", Password = "kati", FirstName = "Mihnea", LastName = "Voronca", PhoneNumber = "0700000002" }
                );
        }
    }
}
