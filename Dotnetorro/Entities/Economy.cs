﻿namespace Dotnetorro.Entities
{
    public class Economy
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double CurrentBudget { get; set; }

        public double CurrentExpense { get; set; }
    }
}
