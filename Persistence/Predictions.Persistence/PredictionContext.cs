using Microsoft.EntityFrameworkCore;
using Predictions.Persistence.Entities;

namespace Predictions.Persistence
{
    public class PredictionContext: DbContext
    {
        public PredictionContext( DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
        
    }
}
