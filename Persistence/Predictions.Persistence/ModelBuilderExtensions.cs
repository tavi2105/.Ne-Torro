using Microsoft.EntityFrameworkCore;
using Predictions.Persistence.Entities;

namespace Predictions.Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Centric"},
                new Company { Id = 2, Name = "Ness" },
                new Company { Id = 3, Name = "Endava" }
                );
            modelBuilder.Entity<Prediction>().HasData(
               new Prediction { Id = 1, CompanyId = 1, Date = System.DateTime.Now, Price = 100 },
               new Prediction { Id = 2, CompanyId = 2, Date = System.DateTime.Now, Price = 100 },
               new Prediction { Id = 3, CompanyId = 3, Date = System.DateTime.Now, Price = 100 }
            );
        }
    }
}
