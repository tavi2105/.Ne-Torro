using Microsoft.AspNetCore.Mvc;
using Predictions.Persistence;
using System.Threading.Tasks;

namespace PredictionsApi.Controllers
{
    [Route("/api/v1/companies")]
    public class CompaniesController : Controller
    {
        private readonly IPredictionRepository _repository;

        public CompaniesController(IPredictionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetCompanies();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetCompanyById(id);
            return Ok(result);
        }

    }
}
