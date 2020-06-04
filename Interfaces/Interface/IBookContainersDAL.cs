using System;
using System.Collections.Generic;
using Interfaces.DTO;

namespace Interfaces
{
    public interface IBookContainersDAL
    {
        public List<BookDTO> GetAllBooks();
        public void UpdateBook(BookDTO book);
        public void AddBook(BookDTO book, int AuthorID);
        public void DeleteBook(BookDTO book);
        public List<AuthorDTO> SearchAuthorByName(string AuthorFN);
        public AuthorDTO GetAuthorByName(string AuthorFN, string AuthorLN);
    }
}
