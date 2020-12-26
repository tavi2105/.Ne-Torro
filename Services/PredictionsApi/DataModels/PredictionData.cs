using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace PredictionsApi.DataModels
{
    public class PredictionData
    {
        [ColumnName("date"), LoadColumn(0)]
        public string Date { get; set; }


        [ColumnName("open"), LoadColumn(1)]
        public float Open { get; set; }


        [ColumnName("high"), LoadColumn(2)]
        public float High { get; set; }


        [ColumnName("low"), LoadColumn(3)]
        public float Low { get; set; }


        [ColumnName("close"), LoadColumn(4)]
        public float Close { get; set; }


        [ColumnName("volume"), LoadColumn(5)]
        public float Volume { get; set; }

        [ColumnName("name"), LoadColumn(6)]
        public string Name { get; set; }
    }
}
