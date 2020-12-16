using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Predictions.Persistence
{
     public interface IPredictionRepository
    {
        public Task<List<Prediction>> GetPredictions();

        public Task<List<Prediction>> GetPredictionsById(int id);

        public Task<List<Company>> GetCompanies();

        public Task<Company> GetCompanyById(int id);
       
    }
}
