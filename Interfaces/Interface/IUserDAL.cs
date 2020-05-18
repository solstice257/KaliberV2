using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.DTO;
namespace Interfaces.Interface
{
    public interface IUserDAL
    {
        public void Register(UserDTO user);
        public void Login(UserDTO user);
    }
}
