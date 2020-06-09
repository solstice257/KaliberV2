using BusinessLibrary.Models;
using Interfaces;
using Interfaces.DTO;
using Kaliber;
using KaliberTests.DatabaseRowSimulations;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.Stubs
{
    public class BookContainerStub : IBookContainersDAL
    {
        public BookRow bookRow;
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

        }

        public void UpdateBook(BookDTO book)
        {

        }
        
        public void DeleteBook(BookDTO book)
        {

        }

        public AuthorDTO GetAuthorByName(string authorFN, string authorLN)
        {
            AuthorDTO x = new AuthorDTO();
            return x;
        }
        public List<AuthorDTO> SearchAuthorByName(string AuthorFN)
        {
            return null;
        }
    }
}
