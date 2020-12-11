using Account.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Persistence
{
     public interface IUserRepository
    {      
        public User SearchUser(string email);
        public string AddUser(UserDTO user);
        public string LoginUser(UserLogin  user);
        public string UpdateUser(User user);
        public string RemoveUser(string email);
    }
}
