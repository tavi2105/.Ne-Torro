using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictions.Persistence.Entities
{
    public class Prediction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public double OpenPrice { get; set; }

        public double ClosePrice { get; set; }

        public double HighPrice { get; set; }

        public double LowPrice { get; set; }

        public long Volume { get; set; }

        public DateTime Date { get; set; }
    }
}
