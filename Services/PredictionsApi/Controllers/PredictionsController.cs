using Microsoft.AspNetCore.Mvc;
using Predictions.Persistence;
using System.Threading.Tasks;

namespace PredictionsApi.Controllers
{
    [Route("/api/predictions")]
    public class PredictionsController : Controller
    {
        private readonly IPredictionRepository _repository;

        public PredictionsController(IPredictionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetPredictions();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetPredictionsById(id);
            return Ok(result);
        }

    }
}
