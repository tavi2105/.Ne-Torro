using Microsoft.EntityFrameworkCore;
using Account.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Persistence
{
   public class UsersRepository: IUserRepository
    {
        private readonly UserContext _context;
        public UsersRepository(UserContext context)
        {
            _context = context;
        }
        public User SearchUser(string email)
        {
            return _context.FindAsync(u => u.Email == email);
        }

        public string AddUser(string email, string password, string firstName, string lastName, string phoneNumber)
        {
            User _user = SearchUser(email);

            if (_user == null)
            {
                _context.Users.Add(new UserDTO(email,password,firstName,lastName,phoneNumber));
                return "SUCCESS";
            }
            
            return "AlreadyUser";
        }

        public string LoginUser(string email, string password)
        {
            User _user = SearchUser(email);

            if(_user != null)
            {
                if(_user.Password == password)
                {
                    return "SUCCESS";
                }
                else
                {
                    return "WrongPassword";
                }
            }
            return "NoUser";
        }
    }
}
