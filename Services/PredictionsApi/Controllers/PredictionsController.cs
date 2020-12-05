using Microsoft.AspNetCore.Mvc;
using Predictions.Persistence;

namespace PredictionsApi.Controllers
{
    [Route("/api/v1/predictions")]
    public class PredictionsController : Controller
    {
        private readonly IPredictionRepository _repository;

        public PredictionsController(IPredictionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok( _repository.GetPredictions());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repository.GetPredictionsById(id));
        }

    }
}
