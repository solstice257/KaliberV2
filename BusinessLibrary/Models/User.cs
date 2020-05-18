using BusinessLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Interface;
using Interfaces.DTO;

namespace BusinessLibrary.Models
{
    class User
    {
        IUserDAL iuserDAL;
        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool LoggedIn { get; private set; }
        public UserType Usertype { get; private set; }
        public User(int UserID, string Username, string Email, string Password, bool LoggedIn, UserType Usertype)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.LoggedIn = LoggedIn;
            this.Usertype = Usertype;
        }

        public void Register(UserDTO user)
        {
            iuserDAL.Register(user);
        }

        public void Login(UserDTO user)
        {
            iuserDAL.Login(user);
        }

    }
    
}
