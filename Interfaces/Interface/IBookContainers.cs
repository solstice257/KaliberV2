using System;
using System.Collections.Generic;
using Interfaces.DTO;

namespace Interfaces
{
    public interface IBookContainersDAL
    {
        public List<BookDTO> GetAllBooks();
        public void UpdateBook(BookDTO book);
        public void AddBook(BookDTO book);
        public void DeleteBook(BookDTO book);
    }
}
