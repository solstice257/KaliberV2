﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessLibrary.Models;
using Interfaces;
using Interfaces.DTO;
using Interfaces.Interface;


namespace BusinessLibrary.Containers
{
    public class BookContainer
    {
        IBookContainersDAL ibookContainersDAL;
        List<Book> Books;

        public BookContainer(IBookContainersDAL ibookContainersDAL)
        {
            Books = new List<Book>();
            this.ibookContainersDAL = ibookContainersDAL;
        }

        public List<Book> GetAllBooks()
        {
            foreach (BookDTO bookDTO in ibookContainersDAL.GetAllBooks())
            {
                Book book = new Book(bookDTO);
                Books.Add(book);
            }
            return Books;
        }

        public void UpdateBook(BookDTO book)
        {
            ibookContainersDAL.UpdateBook(book);
        }

        public void AddBook(BookDTO book)
        {
            int authorID = ibookContainersDAL.GetAuthorByName(book.author.Firstname, book.author.Lastname).AuthorID;
            ibookContainersDAL.AddBook(book, authorID);
        }
        public List<AuthorDTO> SearchAuthorByName(string firstname)
        {
           return ibookContainersDAL.SearchAuthorByName(firstname);
        }

        public List<BookDTO> SearchBookByTitle(string title)
        {
            return ibookContainersDAL.SearchBookByTitle(title);
        }

        public void DeleteBook(long ISBN)
        {
            ibookContainersDAL.DeleteBook(ISBN);
        }
    }
}
