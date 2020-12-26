using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialStatement.Business
{
    public interface IFinancialStatementBusinessLogic
    {
        public Task<FinancialStatementDto> GetById(int id);
        
        public Task Delete(int id);
        
        public Task Update(FinancialStatementDto financialStatement);

        public Task Create(FinancialStatementDto financialStatement);

        public Task<List<FinancialStatementDto>> GetByUserId(int id);



    }
}
