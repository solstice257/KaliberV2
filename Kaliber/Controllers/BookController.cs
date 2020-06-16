using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Kaliber.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server;
using System.IO;
using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces;
using Interfaces.DTO;


namespace Kaliber.Controllers
{
    public class BookController : Controller
    {
        IWebHostEnvironment env;
        private readonly BookContainer bookContainer;

        public BookController(IWebHostEnvironment e, IBookContainersDAL ibookContainerDAL)
        {
            env = e;
            bookContainer = new BookContainer(ibookContainerDAL);
        }

        private Book BookViewToBook(BookView bookView)
        {
            Book book = new Book(bookView.ISBN, bookView.Title, bookView.author.AuthorID, bookView.author.Firstname, bookView.author.Preposition, bookView.author.Lastname, bookView.author.City, bookView.author.Year_of_birth, bookView.author.Year_of_death, bookView.publisher, bookView.Subtitle, bookView.Category, bookView.Book_Root, bookView.Cover_Picture, bookView.Year_of_publication);
            return book;
        }

        public IActionResult Index()
        {
            var booklist = bookContainer.GetAllBooks();
            return View(booklist);
        }

        public IActionResult BookToevoegen()
        {
            return View();
        }
        public IActionResult BoekWijzigen(BookView book)
        {
            return View(book);
        }

        public IActionResult BoekPagina(List<Book> book)
        {
            return View(book);
        }

        public JsonResult SearchAuthorByName(string firstname)
        {
            return Json(new { authors = bookContainer.SearchAuthorByName(firstname) });
        }

        public JsonResult SearchBookByTitle(string title)
        {
            return Json(new { books = bookContainer.SearchBookByTitle(title) });
        }

        public IActionResult AddBook(BookView bookView)
        {
            Book book = BookViewToBook(bookView);
            bookContainer.AddBook(book);
            return View("BookToevoegen");
        }

        public IActionResult DeleteOrUpdate(BookView book, string submitbutton)
        {
            switch (submitbutton)
            {
                case "Update":
                    return (UpdateBook(book));
                case "Delete":
                    return (DeleteBook(book));
                default:
                    break;
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBook(BookView bookView)
        {
            Book book = BookViewToBook(bookView);
            bookContainer.DeleteBook(book);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBook(BookView bookView)
        {
            Book book = BookViewToBook(bookView);
            bookContainer.UpdateBook(book);
            return RedirectToAction("Index");
        }

        public void SaveImagePath(BookView book, IFormFile Cover_Photo)
        {
            if (Cover_Photo != null)
            {
                string filePath = $"{env.ContentRootPath}/images/{Cover_Photo.FileName}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    Cover_Photo.CopyTo(stream);
                }
                book.Cover_Picture = $"~/images/{Cover_Photo.FileName}";

            }
        }
    }
}