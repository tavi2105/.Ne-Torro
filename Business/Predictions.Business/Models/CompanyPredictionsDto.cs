using System.Collections.Generic;

namespace Predictions.Business.Models
{
    public class CompanyPredictionsDto
    {
        public string CompanyName { get; set; }

        public string Description { get; set; }

        public List<PredictionDto> Predictions { get; set; }
    }
}
