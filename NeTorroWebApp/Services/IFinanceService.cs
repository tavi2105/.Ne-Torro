using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public interface IFinanceService
    {
        public Task<List<Finance>> GetFinancialStatement();
    }
}
