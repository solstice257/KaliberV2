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
        public BookRow bookRow = null;
        public List<BookDTO> GetAllBooksReturnValue = null;
        public bool? Testvalue = null;
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
            if(Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }

            if (Testvalue.Value)
            {
                bookRow = new BookRow();
            }
        }

        public void UpdateBook(BookDTO book)
        {
            if (Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }

            if (Testvalue.Value)
            {
                bookRow = new BookRow();
            }
        }
        
        public void DeleteBook(BookDTO book)
        {
            if (Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }

            if (!Testvalue.Value)
            {
                bookRow = new BookRow();
            }
        }

        public AuthorDTO GetAuthorByName(string authorFN, string authorLN)
        {
            AuthorDTO x = new AuthorDTO();
            return x;
        }

        public List<AuthorDTO> SearchAuthorByName(string AuthorFN)
        {
            if (Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            else if (Testvalue == true)
            {
                AuthorDTO x = new AuthorDTO();
                List<AuthorDTO> list = new List<AuthorDTO>();
                list.Add(x);
                return list;
            }
            else
            {
                return null;
            }
        }

        public List<BookDTO> SearchBookByISBN(long ISBN)
        {
            if (Testvalue == null)
            {
                throw new NullReferenceException("Invalid use of stub code. First set field ExistsReturnValue");
            }
            else if (Testvalue == true)
            {
                BookDTO x = new BookDTO();
                List<BookDTO> list = new List<BookDTO>();
                list.Add(x);
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
