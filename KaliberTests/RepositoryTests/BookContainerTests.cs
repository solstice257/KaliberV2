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
        BookContainerStub bookContainerStub;
        BookContainer bookContainer;

        [TestInitialize]
        public void Testinitialize()
        {
            bookContainerStub = new BookContainerStub();
            bookContainer = new BookContainer(bookContainerStub);
        }

        [TestMethod]
        public void GetAllBooksTest()
        {
            List<Book> Books = new List<Book>();
            List<BookDTO> Booklist = new List<BookDTO>();
            bookContainerStub.GetAllBooksReturnValue = Booklist;

            var GetAllBooksResult = bookContainer.GetAllBooks();

            CollectionAssert.AreEqual(Books, GetAllBooksResult);
        }

        [TestMethod]
        public void AddBookSucces()
        {
            bookContainerStub.Testvalue = true;
            Book book = new Book();
            book.author = new Author();
            bookContainer.AddBook(book);
            Assert.IsNotNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        public void AddBookFailed()
        {
            bookContainerStub.Testvalue = false;
            Book book = new Book();
            book.author = new Author();
            bookContainer.AddBook(book);
            Assert.IsNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void AddBookError()
        {
            Book book = new Book();
            book.author = new Author();
            bookContainer.AddBook(book);
            Assert.IsNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        public void DeleteBookSucces()
        {
            bookContainerStub.Testvalue = true;
            Book book = new Book();
            book.author = new Author();
            bookContainer.DeleteBook(book);
            Assert.IsNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        public void DeleteBookFailed()
        {
            bookContainerStub.Testvalue = false;
            Book book = new Book();
            book.author = new Author();
            bookContainer.DeleteBook(book);
            Assert.IsNotNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void DeleteBookError()
        {
            Book book = new Book();
            book.author = new Author();
            bookContainer.DeleteBook(book);
            Assert.IsNotNull(bookContainerStub.bookRow);
        }

        [TestMethod]
        public void UpdateBookSucces()
        {
            bookContainerStub.Testvalue = true;
            BookRow bookRow = new BookRow();
            Book book = new Book();
            book.author = new Author();
            bookContainer.UpdateBook(book);
            Assert.ReferenceEquals(bookRow, bookContainerStub.bookRow);
        }

        [TestMethod]
        public void UpdateBookFailed()
        {
            bookContainerStub.Testvalue = false;
            BookRow bookRow = new BookRow();
            Book book = new Book();
            book.author = new Author();
            bookContainer.UpdateBook(book);
            Assert.AreNotEqual(bookRow, bookContainerStub.bookRow);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void UpdateBookError()
        {
            BookRow bookRow = new BookRow();
            Book book = new Book();
            book.author = new Author();
            bookContainer.UpdateBook(book);
            Assert.AreNotEqual(bookRow, bookContainerStub.bookRow);
        }

        [TestMethod]
        public void SearchAuthorByNameSucces()
        {
            bookContainerStub.Testvalue = true;
            string name = "";
            Assert.IsNotNull(bookContainer.SearchAuthorByName(name));
        }

        [TestMethod]

        public void SearchAuthorByNameFailed()
        {
            bookContainerStub.Testvalue = false;
            string name = "";
            Assert.IsNull(bookContainer.SearchAuthorByName(name));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void SearchAuthorByNameError()
        {
            string name = "";
            Assert.IsNull(bookContainer.SearchAuthorByName(name));
        }

        [TestMethod]
        public void SearchBookByTitleSucces()
        {
            bookContainerStub.Testvalue = false;
            long ISBN = 0;
            Assert.IsNull(bookContainer.SearchBookByISBN(ISBN));
        }

        [TestMethod]
        public void SearchBookByTitleFailed()
        {
            bookContainerStub.Testvalue = false;
            long ISBN = 0;
            Assert.IsNull(bookContainer.SearchBookByISBN(ISBN));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void SearchBookByTitleError()
        {
            long ISBN = 0;
            Assert.IsNull(bookContainer.SearchBookByISBN(ISBN));
        }

        [TestMethod]
        public void BookToBookDTOSucces()
        {
            Book book = new Book();
            book.author = new Author();
            Assert.IsNotNull(bookContainer.BookToBookDTO(book));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void BookToBookDTOFailed()
        {
            Book book = null;
            book.author = new Author();
            Assert.IsNull(bookContainer.BookToBookDTO(book));
        }
    }
}
