using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces;
using Interfaces.Interface;
using Kaliber.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kaliber.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AuthorContainer authorContainer;

        public AuthorController(IAuthorContainerDAL iauthorContainerDAL)
        {
            authorContainer = new AuthorContainer(iauthorContainerDAL);
        }

        private Author AuthorViewToAuthor(AuthorView authorView)
        {
            Author author = new Author(authorView.AuthorID, authorView.Firstname, authorView.Preposition, authorView.Lastname, authorView.City, authorView.Year_of_birth, authorView.Year_of_death);
            return author;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AuthorToevoegen()
        {
            return View();
        }

        public IActionResult AddAuthor(AuthorView authorView)
        {
            Author author = AuthorViewToAuthor(authorView);
            authorContainer.AddAuthor(author);
            return View();
        }
    }
}