using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces.DTO;
using KaliberTests.DatabaseRowSimulations;
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
            int AuthorID = 0;
            BookDTO book = new BookDTO();
            book.author = new AuthorDTO();
            BookContainerStub bookContainerStub = new BookContainerStub();
            Interfaces.IBookContainersDAL ibookContainersDAL = bookContainerStub;
            bookContainerStub.bookRow = new BookRow(book.ISBN, book.Title, AuthorID, book.publisher, book.Subtitle, book.Category, book.Year_of_publication);
            var bookContainer = new BookContainer(ibookContainersDAL);

            bookContainer.AddBook(book);

            Assert.IsNotNull(bookContainerStub.bookRow);
        }

        [TestMethod]

        public void AddBookFailed()
        {
            BookDTO book = new BookDTO();
            book.author = new AuthorDTO();
            BookContainerStub bookContainerStub = new BookContainerStub();
            Interfaces.IBookContainersDAL ibookContainersDAL = bookContainerStub;
            bookContainerStub.bookRow = null;
            var bookContainer = new BookContainer(ibookContainersDAL);

            bookContainer.AddBook(book);

            Assert.IsNull(bookContainerStub.bookRow);
        }
    }
}
