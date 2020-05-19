using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces.DTO;
using KaliberTests.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace KaliberTests.RepositoryTests
{
    [TestClass]
    public class BookContainerTests
    {
        [TestMethod]
        public void GetAllBooksTest()
        {
            List<Book> Books = new List<Book>();
            List<BookDTO> Booklist = new List<BookDTO>();
            var bookContainerStub = new BookContainerStub();
            var bookContainer = new BookContainer(bookContainerStub);
            bookContainerStub.GetAllBooksReturnValue = Booklist;

            var GetAllBooksResult = bookContainer.GetAllBooks();

            CollectionAssert.AreEqual(Books, GetAllBooksResult);
        }

        [TestMethod]

        public void AddBookSucces()
        {
            BookDTO book = new BookDTO();
            var bookContainerStub = new BookContainerStub();
            var bookContainer = new BookContainer(bookContainerStub);

            bookContainer.AddBook(book);

            Assert.IsNotNull(book);
        }
    }
}
