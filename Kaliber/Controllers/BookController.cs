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
        private readonly IWebHostEnvironment he;
        IConfiguration configuration;
        BookShelf _BookShelf;

        public BookController(IWebHostEnvironment e, IConfiguration config)
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
            //    string path =( he.ContentRootPath;

                string filePath = $"{he.WebRootPath}/images/{Cover_Photo.FileName}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    Cover_Photo.CopyTo(stream);
                }
            }

            _BookShelf.AddBook(book);
            return View();

        }
    }
}