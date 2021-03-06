﻿using NeTorroWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
   public interface IUserService
    {
        public Task<JWToken> Login(LoginModel login);
        public Task<Dictionary<string, List<string>>> Register(RegisterModel register);

    }
}
