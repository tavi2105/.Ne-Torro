using System;

namespace StockPrediction.Entities
{
    public class Prediction
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }
    }
}