using Microsoft.EntityFrameworkCore;
using StockPrediction.Entities;


namespace StockPrediction.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
    }  
}