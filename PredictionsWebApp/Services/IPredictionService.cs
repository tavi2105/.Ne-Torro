using PredictionsWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PredictionsWebApp.Services
{

    public interface IPredictionService
    {
        Task<List<Prediction>> GetPredictions();
    }
}
