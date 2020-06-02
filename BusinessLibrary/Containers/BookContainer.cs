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
            int publisherID = ibookContainersDAL.GetPublisherByName(book.publisher.PublisherName).PublisherID;
            ibookContainersDAL.AddBook(book, authorID, publisherID);
        }
        public void DeleteBook(BookDTO book)
        {
            ibookContainersDAL.DeleteBook(book);
        }
    }
}
