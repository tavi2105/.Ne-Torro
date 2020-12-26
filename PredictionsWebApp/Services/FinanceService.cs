using PredictionsWebApp.Extensions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PredictionsWebApp.Services
{
    public class FinanceService:IFinanceService
    {
        private readonly HttpClient _client;

        public FinanceService(HttpClient client)
        {
            _client = client;
        }


        public async Task<List<FinancialStatement.Models.Finance>> GetFinancialStatement()
        {

            var response = await _client.GetAsync("api/financialstatement/0");
            return await response.ReadContentAs<List<FinancialStatement.Models.Finance>>();
        }
    }
}
