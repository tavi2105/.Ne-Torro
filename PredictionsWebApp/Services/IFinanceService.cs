using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictionsWebApp.Services
{
    public interface IFinanceService
    {
        public Task<List<FinancialStatement.Models.Finance>> GetFinancialStatement();
    }
}
