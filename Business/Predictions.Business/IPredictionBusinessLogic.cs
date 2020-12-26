﻿using Predictions.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Predictions.Business
{
    public interface IPredictionBusinessLogic
    {
        public Task<List<PredictionDto>> GetAllPredictions();
        public  Task<CompanyPredictionsDto> GetCompanyPredictions(int id);

    }
}
