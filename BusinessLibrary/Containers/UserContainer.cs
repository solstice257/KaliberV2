using BusinessLibrary.Models;
using Interfaces.DTO;
using Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Containers
{
    class UserContainer
    {
        IUserContainerDAL iuserContainerDAL;
        public UserContainer()
        {

        }

        public bool CheckIfUserExists(UserDTO user)
        {
            return user.LoggedIn = iuserContainerDAL.CheckIfUserExists(user);
        }
    }
}
