using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class PredictionService : IPredictionService
    {
        private readonly HttpClient _client;

        public PredictionService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Prediction>> GetPredictions()
        {
            var response = await _client.GetAsync("api/predictions");
            return await response.ReadContentAs<List<Prediction>>();
        }

    }
}
