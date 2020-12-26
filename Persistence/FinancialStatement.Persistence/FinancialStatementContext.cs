using Microsoft.EntityFrameworkCore;

namespace FinancialStatement.Persistence
{
    public class FinancialStatementContext:DbContext
    {
        public FinancialStatementContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FinancialStatement> FinancialStatements { get; set; }

    }
}
