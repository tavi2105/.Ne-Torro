using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Account.Persistence;
using System.Threading.Tasks;


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

        [HttpPost("Login{email,password}")]
        public async Task<IActionResult> Login(string email, string password)
        {
            return await _repository.LoginUser(email,password);
        }

        [HttpPost("SingIn{email,password,firstName,lastName,phoneNumber}")]
        public async Task<IActionResult> SingIn(string email, string password, string firstName, string lastName, string phoneNumber)
        {
            return await _repository.AddUser(email, password, firstName, lastName, phoneNumber);
        }
        
        [HttpPost("UpdateUser{oldEmail, newEmail, password, firstName, lastName, phoneNumber}")]
        public async Task<IActionResult> UpdateUser(string oldEmail, string newEmail, string password, string firstName, string lastName, string phoneNumber)
        {
            return await _repository.UpdateUser(oldEmail, newEmail, password, firstName, lastName, phoneNumber);
        }

        [HttpPost("RemoveUser{email)")]
        public async Task<IActionResult> RemoveUser(string email)
        {
            return await _repository.RemoveUser(email);
        }
    }
}
