using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Kaliber.Models;
using Kaliber.Repository;

namespace Kaliber.Controllers
{
    public class BookController : Controller
    {
        IConfiguration configuration;
        BookShelf _BookShelf;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Index(Book book)
        {
            _BookShelf.AddBook(book);
        }
    }
}