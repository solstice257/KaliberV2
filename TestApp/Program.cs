using System;
using BusinessLibrary.Containers;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookContainer bookContainer = new BookContainer();
            bookContainer.GetAllBooks();
        }
    }
}
