namespace Account.Persistence.Entities
{
    public class UserDTO
    {
        public UserDTO(string email, string password, string firstName, string lastName, string phoneNumber)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
