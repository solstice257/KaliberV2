﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Kaliber.Models;
using Kaliber.Repository;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server;
using System.IO;

namespace Kaliber.Controllers
{
    public class BookController : Controller
    {
        List<Book> BorrowedBooks;
        private readonly IWebHostEnvironment env;
        IConfiguration configuration;
        BookRepository _BookRepo;

        public BookController(IWebHostEnvironment e, IConfiguration config)
        {
            configuration = config;
            _BookRepo = new BookRepository(configuration);
            env = e;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book, IFormFile Cover_Photo)
        {
            SaveImagePath(book, Cover_Photo);
            _BookRepo.GetAllBooks();
            _BookRepo.AddBook(book);
            return View();
        }

        public void SaveImagePath(Book book, IFormFile Cover_Photo)
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

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        //public List<Book> SearchBook(string SearchElement)
        //{
        //    List<Book> WantedBooks = new List<Book>();
        //    foreach (Book book in books)
        //    {
        //        if (book.Equals(Element))
        //        {
        //            WantedBooks.Add(book);
        //        }
        //    }
        //    return WantedBooks;
        //}
    }
}