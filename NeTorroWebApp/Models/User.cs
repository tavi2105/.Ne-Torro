﻿using System;

namespace NeTorroWebApp.Models
{
    public class User
    {   public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
    }
}
