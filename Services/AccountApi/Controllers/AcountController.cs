using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Account.Persistence.Entities;
using Account.Persistence;

namespace AccountApi.Controllers
{
    [Route("/api/acount")]
    public class AcountController : Controller
    {
        private readonly IUserRepository _repository;

        public PredictionsController(IUserRepository repository)
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

    }
}
