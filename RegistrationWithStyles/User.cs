using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationWithStyles
{
    class User
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public User(string login, string email, string phone, string password)
        {
            Login = login;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}
