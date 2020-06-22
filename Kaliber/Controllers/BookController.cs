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
using Kaliber.Validator;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Kaliber.Controllers
{
    public class BookController : Controller
    {
        BookContainer bookContainer;
        BookValidator boekValidator;

        public BookController(IBookContainersDAL ibookContainerDAL)
        {
            boekValidator = new BookValidator();
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
            ViewData["BookView"] = book;
            return View(book);
        }

        public IActionResult BoekPagina(List<Book> book)
        {
            return View(book);
        }

        public JsonResult SearchAuthorByName(string firstname)
        {
            return Json(new { authors = bookContainer.SearchAuthorByName(firstname)});
        }

        public JsonResult SearchBookByISBN(string ISBN)
        {
            long lgISBN = Convert.ToInt64(ISBN);
            return Json(new { books = bookContainer.SearchBookByISBN(lgISBN)});
        }

        public IActionResult AddBook(BookView bookView)
        {
            if (boekValidator.ValidateISBN(bookView.ISBN) || boekValidator.ValidateTitle(bookView.Title))
            {
                Book book = BookViewToBook(bookView);
                bookContainer.AddBook(book);
                ModelState.AddModelError("Succes", "Boek is toegevoegd");
                return View("BookToevoegen");
            }
            else
            {
                ModelState.AddModelError("Alert", boekValidator.Result);
                return View("BookToevoegen");
            }
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
            ViewData["ID"] = bookView.ISBN;
            if (boekValidator.ValidateTitle(bookView.Title))
            {
                Book book = BookViewToBook(bookView);
                bookContainer.UpdateBook(book);
                ModelState.AddModelError("Succes", "Boek is aangepast!");
                return View("BoekWijzigen", bookView);
            }
            else
            {
                ModelState.AddModelError("Alert", boekValidator.Result);
                return View("BoekWijzigen", bookView);
            }
        }
    }
}