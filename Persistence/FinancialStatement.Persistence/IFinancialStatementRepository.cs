using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialStatement.Persistence
{
    public interface IFinancialStatementRepository
    {
        public Task<FinancialStatement> GetById(int id);
        
        public Task Delete(int id);
        
        public Task Update(FinancialStatement financialStatement);

        public Task Create(FinancialStatement financialStatement);

        public Task<List<FinancialStatement>> GetByUserId(int id);
    }
}
