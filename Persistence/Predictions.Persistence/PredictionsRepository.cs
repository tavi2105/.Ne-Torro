using Microsoft.EntityFrameworkCore;
using Predictions.Persistence.Entities;
using System.Collections.Generic;
using System.Linq;
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
            return _context.Predictions.Include(p => p.Company).Take(500).Distinct().ToListAsync();
        }
        public Task<List<Prediction>> GetPredictionsById(int id)
        {
            return _context.Predictions.Include(p => p.Company).Where( p => p.CompanyId == id).ToListAsync();
        }
        public Task<List<Company>> GetCompanies()
        {
            return _context.Companies.Include(p => p.Predictions).ToListAsync();
        }
        public Task<Company> GetCompanyById(int id)
        {
            return _context.Companies.Include(p => p.Predictions).FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<Company> GetCompanyByName(string name)
        {
            return _context.Companies.Include(p => p.Predictions).FirstOrDefaultAsync(c => c.Name == name);
        }

        public Task CreatePrediction(Prediction prediction)
        {
            _context.Predictions.Add(prediction);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
