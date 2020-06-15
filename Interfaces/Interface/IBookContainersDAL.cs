﻿using System;
using System.Collections.Generic;
using Interfaces.DTO;

namespace Interfaces
{
    public interface IBookContainersDAL
    {
        public List<BookDTO> GetAllBooks();
        public void UpdateBook(BookDTO book);
        public void AddBook(BookDTO book, int AuthorID);
        public void DeleteBook(long ISBN);
        public List<AuthorDTO> SearchAuthorByName(string AuthorFN);
        public AuthorDTO GetAuthorByName(string AuthorFN, string AuthorLN);
        public List<BookDTO> SearchBookByTitle(string title);
    }
}
