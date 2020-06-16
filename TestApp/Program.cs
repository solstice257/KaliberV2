using System;
using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces.DTO;
using KaliberTests.Stubs;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookContainerStub bookContainerStub = new BookContainerStub();
            BookContainer bookContainer = new BookContainer(bookContainerStub);

            bookContainerStub.Testvalue = true;
            Book book = new Book();
            book.author = new Author();
            bookContainer.AddBook(book);
        }
    }
}
