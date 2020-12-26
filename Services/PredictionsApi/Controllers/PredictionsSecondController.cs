using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using PredictionsApi.DataModels;

namespace PredictionsApi.Controllers
{
    [Route("api/v2/predictions2")]
    [ApiController]
    public class PredictionsSecondController : ControllerBase
    {
        private readonly PredictionEnginePool<PredictionData, DataPredictions> _predictionEnginePool;

        public PredictionsSecondController(PredictionEnginePool<PredictionData, DataPredictions> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] PredictionData input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            DataPredictions prediction = _predictionEnginePool.Predict(modelName: "StockPrediction_trainML", example: input);

            float predictedData = prediction.Score;

            return Ok(predictedData);
        }
    }
}
