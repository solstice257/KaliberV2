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
        public IActionResult Index()
        {
            var booklist = bookContainer.GetAllBooks();
            return View(booklist);
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