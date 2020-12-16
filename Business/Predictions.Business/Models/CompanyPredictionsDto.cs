using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictions.Business.Models
{
   public class CompanyPredictionsDto
    {
        public string CompanyName { get; set; }

        public string Description { get; set; }

        public List<PredictionDto> Predictions { get; set; }
    }
}
