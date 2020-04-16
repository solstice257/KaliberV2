using System;
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
using System.IO;

namespace Kaliber.Controllers
{
    public class BookController : Controller
    {
        private readonly IHostingEnvironment he;
        IConfiguration configuration;
        BookShelf _BookShelf;

        public BookController(IHostingEnvironment e, IConfiguration config)
        {
            configuration = config;
            _BookShelf = new BookShelf(configuration);
            he = e;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveImagePath(Book book, IFormFile Cover_Photo)
        {
            if (Cover_Photo != null)
            {
                var filename = Path.Combine(he.WebRootPath, Path.GetFileName(Cover_Photo.FileName));
                Cover_Photo.CopyTo(new FileStream(filename, FileMode.Create));
            }

            _BookShelf.AddBook(book);
            return View();
        }
    }
}