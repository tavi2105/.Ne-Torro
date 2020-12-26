using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictionsApi.DataModels
{
    public class DataPredictions
    {
        [ColumnName("PredictedLabel")]
        public float Prediction { get; set; }

        public float Probability { get; set; }

        [ColumnName("Score")]
        public float Score { get; set; }
    }
}
