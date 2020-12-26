using Account.Persistence.Entities;
using System.Linq;

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

        public string AddUser(UserDTO user)
        {
            User _user = SearchUser(user.Email);
            var maxId = _context.Users.Max(u => u.Id);
            maxId = maxId + 1;
            if (_user == null)
            {
                var newUser = new User() { Email = user.Email, Id = maxId, Password = user.Password, FirstName = user.FirstName, LastName = user.LastName, PhoneNumber = user.PhoneNumber };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return "SUCCESS";
            }
            
            return "AlreadyUser";
        }

        public string LoginUser(UserLogin user)
        {
            User _user = SearchUser(user.Email);

            if(_user != null)
            {
                if(_user.Password == user.Password)
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

        public string UpdateUser(User user)
        {
            User _user = SearchUser(user.Email);

            if(_user != null)
            {
                _user.Email = user.Email;
                _user.Password = user.Password;
                _user.FirstName = user.FirstName;
                _user.LastName = user.LastName;
                _user.PhoneNumber = user.PhoneNumber;

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
