using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Predictions.Persistence
{
   public class PredictionsRepository: IPredictionRepository
    {
        private readonly PredictionContext _context;
        public PredictionsRepository(PredictionContext context)
        {
            _context = context;
        }
        public List<Prediction> GetPredictions()
        {
            return _context.Predictions.ToList();
        }
        public Prediction GetPredictionsById(int id)
        {
            return _context.Predictions.Find(id);
        }
        public List<Company> GetCompanies()
        {
            return _context.Companies.ToList();
        }
        public Company GetCompaniesById(int id)
        {
            return _context.Companies.Find(id);
        }
    }
}
