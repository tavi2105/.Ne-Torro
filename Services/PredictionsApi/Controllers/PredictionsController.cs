using Microsoft.AspNetCore.Mvc;
using Predictions.Business;
using Predictions.Persistence;
using System.Threading.Tasks;
using PredictionsApi.DataModels;
using Microsoft.Extensions.ML;
using System;
using Predictions.Persistence.Entities;

namespace PredictionsApi.Controllers
{
    [Route("/api/v1/predictions")]
    public class PredictionsController : ControllerBase
    {

        private readonly IPredictionBusinessLogic _businessLogic;
        private readonly PredictionEnginePool<PredictionData, DataPredictions> _predictionEnginePool;
        private readonly IPredictionRepository _companyRepository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _businessLogic.GetAllPredictions();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _businessLogic.GetCompanyPredictions(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        public PredictionsController(PredictionEnginePool<PredictionData, DataPredictions> predictionEnginePool, IPredictionBusinessLogic businessLogic, IPredictionRepository repository)
        {
            _businessLogic = businessLogic;
            _predictionEnginePool = predictionEnginePool;
            _companyRepository = repository;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PredictionModel input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var company  = await _companyRepository.GetCompanyByName(input.CompanyName);
            var predict = new PredictionData { Open = (float)input.OpenPrice, Date = Convert.ToString(input.Date), High = (float)input.HighPrice, Low = (float)input.LowPrice, Name = input.CompanyName, Volume = input.Volume };
            DataPredictions prediction = _predictionEnginePool.Predict(modelName: "StockPrediction_trainML",predict);
            var newPrediction = new Prediction { ClosePrice = prediction.Score, CompanyId = company.Id, HighPrice = input.HighPrice, LowPrice = input.LowPrice, OpenPrice = input.OpenPrice, Volume = (long)input.Volume };


            _businessLogic.CreatePrediction(newPrediction);
            float predictedData = prediction.Score;

            Console.WriteLine(predictedData);
            return Ok(predictedData);
        }
        /*
        [HttpPost]
        public async Task<IActionResult> PostJustName([FromBody] string companyName, string date)
        {
            var result = await _companyRepository.GetCompanyByName(companyName);
            if (result == null)
                return NotFound();
            return Ok(result);
        }*/
    }
}

