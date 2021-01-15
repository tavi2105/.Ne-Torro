using NeTorroWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public interface  ISessionService
    {
          void SetToken(JWToken token);
          Task<JWToken> GetToken();
        public void DeleteToken();




    }
}
