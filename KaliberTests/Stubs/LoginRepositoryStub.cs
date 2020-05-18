using System;
using System.Collections.Generic;
using System.Text;
using Kaliber.Models;
using Kaliber.Interfaces;

namespace KaliberTests.Stubs
{
    public class LoginRepositoryStub : ILoginRepository
    {
        public bool? ExistsReturnValue = null;

        public bool Exists(UserView user)
        {
            if (ExistsReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field AddUserValue");
            }
            return ExistsReturnValue.Value;
        }
    }
}
