using Predictions.Business.Models;
using Predictions.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictions.Business
{
    public interface IPredictionBusinessLogic
    {
        public Task<List<PredictionDto>> GetAllPredictions();
        public  Task<CompanyPredictionsDto> GetCompanyPredictions(int id);

    }
}
