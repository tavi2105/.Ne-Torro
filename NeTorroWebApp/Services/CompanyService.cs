using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class CompanyService:ICompanyService
    {
        private readonly HttpClient _client;

        public CompanyService(HttpClient client)
        {
            _client = client;
        }
     public async Task<List<Company>> GetCompanies()
        {
            var response = await _client.GetAsync("api/companies");
            return await response.ReadContentAs<List<Company>>();
        }

    }
}
