using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaliber.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using KaliberTests.Stubs;
using Kaliber.Controllers;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;

namespace Kaliber.Repository.Tests
{
    [TestClass()]
    public class RegisterRepositioryTests
    {
            [TestMethod]
        public void RegisterSucces()
        {
            var user = new User();
            user.Username = "Jan";
            user.Password = "Jan123";
            user.Email = "Jan@gmail.com";
            var registerRepositoryStub = new RegisterRepositoryStub();
            var registerController = new RegisterController(null, registerRepositoryStub);

            registerRepositoryStub.AddedUserReturnValue = true;

            var registerResult = registerController.AddedUser(user);

            Assert.IsTrue(registerResult);
        }
    }
}