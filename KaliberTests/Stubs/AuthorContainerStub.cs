using BusinessLibrary.Models;
using Interfaces.DTO;
using Interfaces.Interface;
using KaliberTests.DatabaseRowSimulations;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.Stubs
{
    class AuthorContainerStub : IAuthorContainerDAL
    {
        public AuthorRow authorRow = null;
        public bool? Testvalue = null;
        
        public void AddAuthor(AuthorDTO authorDTO)
        {
            if (Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }

            if (Testvalue.Value)
            {
                authorRow = new AuthorRow();
            }
        }
    }
}
