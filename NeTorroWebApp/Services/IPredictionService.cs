using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{

    public interface IPredictionService
    {
        Task<List<Prediction>> GetPredictions();
    }
}
