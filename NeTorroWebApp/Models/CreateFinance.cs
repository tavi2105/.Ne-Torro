using System;

namespace NeTorroWebApp.Models
{
    public class CreateFinance
    {
        public double Income { get; set; }

        public double Expense { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
