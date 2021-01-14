using NeTorroWebApp.Extensions;
using NeTorroWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public class AuthorizationService:IUserService
    {
        private readonly HttpClient _client;

        public AuthorizationService(HttpClient client)
        {
            _client = client;
        }

        public async Task<JWToken> Login( LoginModel login)
        {
            var json = JsonConvert.SerializeObject(login);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/authenticate/login", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<JWToken>();
            }
            return await Task.FromResult(JWToken.EmptyToken);
        }

        public async Task<Dictionary<string, List<string>>> Register(RegisterModel register)
        {
            var json = JsonConvert.SerializeObject(register);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/authenticate/register", httpContent);
            if(!response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var deserializedJson = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(result);
                return await Task.FromResult(deserializedJson);
            }
            return await Task.FromResult(new Dictionary<string, List<string>>());

        }

    }
}
