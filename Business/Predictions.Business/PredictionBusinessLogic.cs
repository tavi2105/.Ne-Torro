using Predictions.Business.Models;
using Predictions.Persistence;
using Predictions.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Predictions.Business
{
    public class PredictionBusinessLogic: IPredictionBusinessLogic

    {
        private readonly IPredictionRepository _repository;
        public PredictionBusinessLogic(IPredictionRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PredictionDto>> GetAllPredictions()
        {
            var predictions = await _repository.GetPredictions();
            return MapPredictionsToDtos(predictions);
        }
        public async Task<List<PredictionDto>> GetPredictionDtosForCompany(int idCompany)
        {
            var predictions = await _repository.GetPredictionsById(idCompany);
            return MapPredictionsToDtos(predictions);
        }
        public async Task<CompanyPredictionsDto> GetCompanyPredictions(int id)
        {
            var asyncCompany = _repository.GetCompanyById(id);
            var company = await asyncCompany;
            CompanyPredictionsDto companyPredictions = new CompanyPredictionsDto();
            if(company != null)
            {
                var predictionDtos = MapPredictionsToDtos(company.Predictions);
                 companyPredictions = new CompanyPredictionsDto
                {
                    CompanyName = company.Name,
                    Description = company.Description,
                    Predictions = predictionDtos
                };
            }
            return companyPredictions;

        }
        private List<PredictionDto> MapPredictionsToDtos(List<Prediction> predictions)
        {
            List<PredictionDto> predictionsDto = new List<PredictionDto>();
            foreach( var prediction in predictions)
            {
                var predictionDto = new PredictionDto
                {
                    ClosePrice = prediction.ClosePrice,
                    CompanyName = prediction.Company.Name,
                    Date = prediction.Date,
                    HighPrice = prediction.HighPrice,
                    LowPrice = prediction.LowPrice,
                    OpenPrice = prediction.OpenPrice,
                    Volume = prediction.Volume
                };
                predictionsDto.Add(predictionDto);
            }
            return predictionsDto;
        }
     }
}
