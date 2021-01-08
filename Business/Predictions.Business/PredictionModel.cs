using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictions.Business
{
    public class PredictionModel
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
