using System;

namespace FinancialStatement.Business
{
    public class FinancialStatementDto
    {
        public int Id { get; set; }

        public double Income { get; set; }

        public double Expense { get; set; }

        public DateTime Date { get; set; }
    }
}
