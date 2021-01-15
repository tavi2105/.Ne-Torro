using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeTorroWebApp.Models
{
    public class JWToken
    {
        public static JWToken EmptyToken => new JWToken();
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
    }
}
