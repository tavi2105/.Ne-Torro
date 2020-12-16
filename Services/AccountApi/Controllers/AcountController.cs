using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Account.Persistence;
using System.Threading.Tasks;
using Account.Business;
using Account.Persistence.Entities;

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
        public  IActionResult UpdateUser([FromBody] User user)
        {
            var result = _repository.UpdateUser(user);
            if (result == "SUCCESS")
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete]
        public  IActionResult RemoveUser([FromBody] string email)
        { 
            var result =  _repository.RemoveUser(email);
            if (result == "SUCCESS")
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
