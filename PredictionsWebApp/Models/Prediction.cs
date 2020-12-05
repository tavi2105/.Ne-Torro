using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictionsWebApp.Models
{
    public class Prediction
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public double OpenPrice { get; set; }

        public double ClosePrice { get; set; }

        public double HighPrice { get; set; }

        public double LowPrice { get; set; }

        public long Volume { get; set; }

        public DateTime Date { get; set; }
    }
}
