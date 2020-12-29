using Microsoft.AspNetCore.Mvc;
using Account.Persistence;
using Account.Persistence.Entities;
using Microsoft.AspNetCore.Authorization;

namespace AccountApi.Controllers
{
    [Route("/api/account")]
    public class AccountController : Controller
    {
        private readonly IUserRepository _repository;

        public AccountController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("login")]
        [BasicAuthentication]
        public  IActionResult Login([FromBody] UserLogin user)
        {
           var  result =  _repository.LoginUser(user);
            return Ok(result);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserDTO user)
        {
            var result =  _repository.AddUser(user);
            if (result == "SUCCESS")
            {
                return NoContent();
            }
            return NotFound();
        }
        
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            var result = _repository.UpdateUser(user);
            if (result == "SUCCESS")
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public IActionResult RemoveUser([FromBody] string email)
        { 
            var result =  _repository.RemoveUser(email);
            if (result == "Success")
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
