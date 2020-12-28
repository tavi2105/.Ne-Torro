using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly HttpClient _client;

        public FinanceService(HttpClient client)
        {
            _client = client;
        }


        public async Task<List<Finance>> GetFinancialStatement()
        {
            var response = await _client.GetAsync("api/financialstatement/2");
            return await response.ReadContentAs<List<Finance>>();
        }

        public async Task<Finance> GetFinancialStatementById(int id)
        {
            var response = await _client.GetAsync("api/financialstatement/find/" + id);
            return await response.ReadContentAs<Finance>();
        }

        public async void DeleteFinancialStatement(int id)
        {
            var response = await _client.DeleteAsync("api/financialstatement/" + id);
        }

        public async void UpdateFinancialStatement(Finance finance)
        {
            var json = JsonConvert.SerializeObject(finance);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PutAsync("api/financialstatement/" + finance.Id, httpContent);
        }

        public async void CreateFinancialStatement(CreateFinance finance)
        {
            var json = JsonConvert.SerializeObject(finance);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/financialstatement/2", httpContent);
        }
    }
}


