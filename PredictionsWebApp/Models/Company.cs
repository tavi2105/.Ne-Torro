using System.Collections.Generic;

namespace PredictionsWebApp.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Prediction> Predictions { get; set; }


    }
}
