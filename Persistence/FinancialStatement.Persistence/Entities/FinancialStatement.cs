using System;

namespace FinancialStatement.Persistence
{
    public class FinancialStatement
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double Income { get; set; }

        public double Expense { get; set; }

        public DateTime Date { get; set; }
    }
}
