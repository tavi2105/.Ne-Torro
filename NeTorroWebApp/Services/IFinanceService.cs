using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public interface IFinanceService
    {
        public Task<List<Finance>> GetFinancialStatement();
        public void DeleteFinancialStatement(int id);
        public void UpdateFinancialStatement(Finance finance);
        public void CreateFinancialStatement( CreateFinance finance);
        public  Task<Finance> GetFinancialStatementById(int id);


    }
}
