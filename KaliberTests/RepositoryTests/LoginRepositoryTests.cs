using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaliber.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Kaliber.Models;
using Kaliber.Controllers;
using KaliberTests.Stubs;

namespace Kaliber.Repository.Tests
{
    [TestClass()]
    public class LoginRepositoryTests
    {
        [TestMethod()]
        public void LoginSucces()
        {
            var user = new UserView();
            user.Username = "Jan";
            user.Password = "Jan123";
            user.Email = "Jan@gmail.com";
            var loginRepositoryStub = new LoginRepositoryStub();
            var loginController = new LoginController(null, loginRepositoryStub);

            loginRepositoryStub.ExistsReturnValue = true;

            var loginResult = loginController.Login(user);

            Assert.IsTrue(loginResult);
        }
    }
}