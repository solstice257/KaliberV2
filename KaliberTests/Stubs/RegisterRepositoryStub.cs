using System;
using System.Collections.Generic;
using System.Text;
using Kaliber.Interfaces;
using Kaliber.Models;

namespace KaliberTests.Stubs
{
    public class RegisterRepositoryStub : IRegisterRepository
    {
        public bool? AddedUserReturnValue = null;

        public bool AddedUser(User user)
        {
            if (AddedUserReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field AddUserValue");
            }
            return AddedUserReturnValue.Value;
        }
    }
}
