using NeTorroWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
   public interface IUserService
    {
        public  Task<string> Login(LoginModel login);
        public  Task Register(RegisterModel register);

    }
}
