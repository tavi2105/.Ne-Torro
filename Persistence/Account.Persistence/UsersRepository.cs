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
            return _context.Users.First(u => u.Email == email);
        }

        public string AddUser(string email, string password, string firstName, string lastName, string phoneNumber)
        {
            User _user = SearchUser(email);

            if (_user == null)
            {
                User user = new User();
                user.Email = email;
                user.Password = password;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.PhoneNumber = phoneNumber;

                _context.Users.Add(user);
                _context.SaveChanges();
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

        public string UpdateUser(string oldEmail, string newEmail, string password, string firstName, string lastName, string phoneNumber)
        {
            User _user = SearchUser(oldEmail);

            if(_user != null)
            {
                _user.Email = newEmail;
                _user.Password = password;
                _user.FirstName = firstName;
                _user.LastName = lastName;
                _user.PhoneNumber = phoneNumber;

                _context.SaveChanges();

                return "Success";
            }
            else
                return "Failed";
            
        }

        public string RemoveUser(string email)
        {
            User _user = SearchUser(email);
            
            if(_user != null)
            {
                _context.Users.Remove(_user);
                return "Success";
            }
            else
                return "Failed";
        }
   }
}
