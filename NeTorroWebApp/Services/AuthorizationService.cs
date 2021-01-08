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

        public async Task<string> Login( LoginModel login)
        {
            var json = JsonConvert.SerializeObject(login);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/authenticate/login", httpContent);
            return await response.ReadContentAs<string>();
        }

        public async Task Register(RegisterModel register)
        {
            var json = JsonConvert.SerializeObject(register);
            var httpContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/authenticate/register", httpContent);
            
        }

    }
}
