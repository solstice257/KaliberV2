using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using KaliberTests.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.RepositoryTests
{  
    [TestClass]
    public class AuthorContainerTests
    {
        AuthorContainerStub authorContainerStub;
        AuthorContainer authorContainer;

        [TestInitialize]
        public void TestInitialize()
        {
            authorContainerStub = new AuthorContainerStub();
            authorContainer = new AuthorContainer(authorContainerStub);
        }

        [TestMethod]
        public void AddAuthorSucces()
        {
            authorContainerStub.Testvalue = true;
            Author author = new Author();
            authorContainer.AddAuthor(author);
            Assert.IsNotNull(authorContainerStub.authorRow);
        }

        [TestMethod]
        public void AddAuthorFailed()
        {
            authorContainerStub.Testvalue = false;
            Author author = new Author();
            authorContainer.AddAuthor(author);
            Assert.IsNull(authorContainerStub.authorRow);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void AddAuthorError()
        {
            Author author = new Author();
            authorContainer.AddAuthor(author);
            Assert.IsNull(authorContainerStub.authorRow);
        }
    }
}
