using Account.Persistence.Entities;

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
