using Microsoft.EntityFrameworkCore;
using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictions.Persistence
{
   public class PredictionsRepository: IPredictionRepository
    {
        private readonly PredictionContext _context;
        public PredictionsRepository(PredictionContext context)
        {
            _context = context;
        }
        public Task<List<Prediction>>GetPredictions()
        {
            return _context.Predictions.Take(100).ToListAsync();
        }
        public Task<Prediction> GetPredictionsById(int id)
        {
            return _context.Predictions.FindAsync(id).AsTask();
        }
        public Task<List<Company>> GetCompanies()
        {
            return _context.Companies.ToListAsync();
        }
        public Task<Company> GetCompaniesById(int id)
        {
            return _context.Companies.FindAsync(id).AsTask();
        }
    }
}
