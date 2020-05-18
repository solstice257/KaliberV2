using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DTO
{
    class UserDTO
    {
        public enum UserType
        {
            Admin = 1,
            User = 2
        }

        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool LoggedIn { get; private set; }
        public UserType Usertype { get; private set; }
    }
}
