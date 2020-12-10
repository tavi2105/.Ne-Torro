using Microsoft.AspNetCore.Mvc;
using Predictions.Business;
using Predictions.Persistence;
using System.Threading.Tasks;

namespace PredictionsApi.Controllers
{
    [Route("/api/predictions")]
    public class PredictionsController : Controller
    {
        private readonly IPredictionBusinessLogic _businessLogic;

        public PredictionsController(IPredictionBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

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


    }
}
