using Account.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Persistence
{
     public interface IUserRepository
    {      
        public bool SearchUser(UserDTO user);
        public string AddUser(UserDTO user);
        public string LoginUser(UserDTO user);
    }
}
