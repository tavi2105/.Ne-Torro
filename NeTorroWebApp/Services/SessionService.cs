using NeTorroWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace NeTorroWebApp.Services
{
    public class SessionService:ISessionService
    {
        private const string AuthenticationToken = "authenticationToken";
        private readonly ILocalStorageService _localStorage;
        public SessionService(ILocalStorageService localStorageService)
        {
            _localStorage = localStorageService;
        }
        public async void SetToken(JWToken token)
        {
            await _localStorage.SetItemAsync(AuthenticationToken, token);
        }
        public async Task<JWToken> GetToken()
        {
            return await _localStorage.GetItemAsync<JWToken>(AuthenticationToken);
        }
    }
}
