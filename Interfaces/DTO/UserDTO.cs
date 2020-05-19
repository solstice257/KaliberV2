using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DTO
{
    public class UserDTO
    {
        public long UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public string Usertype { get; set; }
    }
}
