using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly HttpClient _client;
        private readonly ISessionService _sessionService;
        private string Id;
        public FinanceService(HttpClient client, ISessionService sessionService)
        {
            _client = client;
            _sessionService = sessionService;
        }

        private async Task SetTokenToHeader()
        {
            var token = await _sessionService.GetToken();
            Id = token.IdUser;
            _client.DefaultRequestHeaders.Authorization =
             new AuthenticationHeaderValue("Bearer", token.Token);
            
        }
        public async Task<List<Finance>> GetFinancialStatement()
        {
            await SetTokenToHeader();
            var response = await _client.GetAsync("api/financialstatement/"+Id);
            return await response.ReadContentAs<List<Finance>>();
        }

        public async Task<Finance> GetFinancialStatementById(int id)
        {
            SetTokenToHeader();
            var response = await _client.GetAsync("api/financialstatement/find/" + id);
            return await response.ReadContentAs<Finance>();
        }

        public async void DeleteFinancialStatement(int id)
        {
            SetTokenToHeader();
            var response = await _client.DeleteAsync("api/financialstatement/" + id);
        }

        public async void UpdateFinancialStatement(Finance finance)
        {
            SetTokenToHeader();
            var json = JsonConvert.SerializeObject(finance);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PutAsync("api/financialstatement/" + finance.Id, httpContent);
        }

        public async void CreateFinancialStatement(CreateFinance finance)
        {
            SetTokenToHeader();
            var json = JsonConvert.SerializeObject(finance);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/financialstatement/" + Id, httpContent);
        }
    }
}


