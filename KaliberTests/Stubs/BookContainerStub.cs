using BusinessLibrary.Models;
using Interfaces;
using Interfaces.DTO;
using Kaliber;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.Stubs
{
    public class BookContainerStub : IBookContainersDAL
    {
        public List<BookDTO> GetAllBooksReturnValue = null;
        public string AddBookError = null;
        public List<BookDTO> GetAllBooks()
        {
            if (GetAllBooksReturnValue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }

            return GetAllBooksReturnValue;
        }

        public void AddBook(BookDTO book, int AuthorID)
        {
            book = null;
        }

        public void UpdateBook(BookDTO book)
        {

        }
        
        public void DeleteBook(BookDTO book)
        {

        }

        public AuthorDTO GetAuthorByName(string authorFN, string authorLN)
        {
            return null;
        }
    }
}
