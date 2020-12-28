using Microsoft.EntityFrameworkCore;
using Predictions.Persistence.Entities;

namespace Predictions.Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Centric", Description="Planeta"},
                new Company { Id = 2, Name = "Ness", Description = "Planeta" },
                new Company { Id = 3, Name = "Endava", Description = "Planeta" }
                );
            modelBuilder.Entity<Prediction>().HasData(
               new Prediction { Id = 1, CompanyId = 1, Date = System.DateTime.Now, OpenPrice = 100, ClosePrice = 110, Volume = 2323, HighPrice = 222, LowPrice=33},
               new Prediction { Id = 2, CompanyId = 2, Date = System.DateTime.Now, OpenPrice = 100, ClosePrice = 110, Volume = 4321, HighPrice = 422, LowPrice = 33 },
               new Prediction { Id = 3, CompanyId = 3, Date = System.DateTime.Now, OpenPrice = 100, ClosePrice = 110, Volume = 5212, HighPrice = 5622, LowPrice = 100 }
            );
        }
    }
}
