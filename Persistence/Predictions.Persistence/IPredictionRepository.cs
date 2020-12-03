using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Predictions.Persistence
{
     public interface IPredictionRepository
    {
        public List<Prediction> GetPredictions();

        public Prediction GetPredictionsById(int id);

        public List<Company> GetCompanies();

        public Company GetCompaniesById(int id);
       
    }
}
