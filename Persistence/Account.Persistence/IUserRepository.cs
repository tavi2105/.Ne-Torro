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
        public string AddUser(string email, string password, string firstName, string lastName, string phoneNumber);
        public string LoginUser(string email, string password);
        public string UpdateUser(string oldEmail, string newEmail, string password, string firstName, string lastName, string phoneNumber);
        public string RemoveUser(string email);
    }
}
