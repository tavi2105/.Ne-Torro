using System;

namespace NeTorroWebApp.Models
{
    public class Prediction
    {
        public string CompanyName { get; set; }

        public int CompanyId { get; set; }

        public double OpenPrice { get; set; }

        public double ClosePrice { get; set; }

        public double HighPrice { get; set; }

        public double LowPrice { get; set; }

        public long Volume { get; set; }

        public DateTime Date { get; set; }
    }
}
