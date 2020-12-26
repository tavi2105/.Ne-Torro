using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class FinanceService:IFinanceService
    {
        private readonly HttpClient _client;

        public FinanceService(HttpClient client)
        {
            _client = client;
        }


        public async Task<List<Finance>> GetFinancialStatement()
        {

            var response = await _client.GetAsync("api/financialstatement/0");
            return await response.ReadContentAs<List<Finance>>();
        }
    }
}
