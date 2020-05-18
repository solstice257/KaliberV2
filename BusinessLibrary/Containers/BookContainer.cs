using System;
using System.Collections.Generic;
using System.Text;
using BusinessLibrary.Models;
using Interfaces;
using Interfaces.DTO;
using Interfaces.Interface;


namespace BusinessLibrary.Containers
{
    class BookContainer
    {
        IBookContainersDAL ibookContainersDAL;
        List<Book> Books;

        public BookContainer()
        {
            Books = new List<Book>();

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
    }
}
