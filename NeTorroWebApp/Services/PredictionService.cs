using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System;

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

        public async void CreatePredictionStatement(Prediction prediction)
        {
            var json = JsonConvert.SerializeObject(prediction);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            Console.WriteLine("Fuck you, dotnet" + httpContent + json);
            var response = await _client.PostAsync("api/predictions", httpContent);
        }
    }
}
