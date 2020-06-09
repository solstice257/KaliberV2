using System;
using BusinessLibrary.Containers;
using Interfaces.DTO;
using KaliberTests.Stubs;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookDTO book = new BookDTO();
            book.author = new AuthorDTO();
            book.author.Firstname = "";
            book.author.Lastname = "";
            BookContainerStub bookContainerStub = new BookContainerStub();
            Interfaces.IBookContainersDAL ibookContainersDAL = bookContainerStub;
            var bookContainer = new BookContainer(ibookContainersDAL);

            bookContainer.AddBook(book);
        }
    }
}
