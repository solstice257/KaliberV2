using System;
using System.Collections.Generic;
using System.Text;
using BusinessLibrary.Models;
using Interfaces.Interface;


namespace BusinessLibrary.Containers
{
    class BookContainer
    {
        Interfaces.IBookContainersDAL ibookContainersDAL;
        List<Book> Books;

        public BookContainer()
        {
            Books = new List<Book>();
        }

        public List<Book> GetAllBooks()
        {
           return ibookContainersDAL.GetAllBooks();
        }

        public void UpdateBook(Book book)
        {

            ibookContainersDAL.UpdateBook(book);
        }
    }
}
