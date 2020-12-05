using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgdetEconomy.Persistence
{
    class BudgetEconomyContext:DbContext
    {
        public BudgetEconomyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Economy> Economies { get; set; }

    }
}
