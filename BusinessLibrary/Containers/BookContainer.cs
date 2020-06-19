using System;
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

        public BookDTO BookToBookDTO(Book book)
        {
            AuthorDTO authorDTO = new AuthorDTO(book.author.AuthorID, book.author.Firstname, book.author.Preposition, book.author.Lastname, book.author.City, book.author.Year_of_birth, book.author.Year_of_death);
            BookDTO bookDTO = new BookDTO(book.ISBN, book.Title, authorDTO, book.publisher, book.Subtitle, book.Category, book.Book_Root, book.Cover_Picture, book.Year_of_publication);
            return bookDTO;
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

        public void UpdateBook(Book book)
        {
            BookDTO bookDTO = BookToBookDTO(book);
            ibookContainersDAL.UpdateBook(bookDTO);
        }

        public void AddBook(Book book)
        {
            BookDTO bookDTO = BookToBookDTO(book);
            int authorID = ibookContainersDAL.GetAuthorByName(bookDTO.author.Firstname, bookDTO.author.Lastname).AuthorID;
            ibookContainersDAL.AddBook(bookDTO, authorID);
        }
        public List<AuthorDTO> SearchAuthorByName(string firstname)
        {
            return ibookContainersDAL.SearchAuthorByName(firstname);
        }

        public List<BookDTO> SearchBookByTitle(string title)
        {
            return ibookContainersDAL.SearchBookByTitle(title);
        }

        public void DeleteBook(Book book)
        {
            BookDTO bookDTO = BookToBookDTO(book);
            ibookContainersDAL.DeleteBook(bookDTO);
        }
    }
}
