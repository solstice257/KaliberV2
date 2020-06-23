using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLibrary.Containers;
using BusinessLibrary.Models;
using Interfaces;
using Interfaces.Interface;
using Kaliber.Models;
using Kaliber.Validator;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kaliber.Controllers
{
    public class AuthorController : Controller
    {
        BookController bookController;
        AuthorContainer authorContainer;
        AuthorValidator authorValidator;

        public AuthorController(IAuthorContainerDAL iauthorContainerDAL)
        {
            authorValidator = new AuthorValidator();
            bookController = new BookController(null);
            authorContainer = new AuthorContainer(iauthorContainerDAL);
        }

        private Author AuthorViewToAuthor(AuthorView authorView)
        {
            Author author = new Author(authorView.AuthorID, authorView.Firstname, authorView.Preposition, authorView.Lastname, authorView.City, Convert.ToInt32(authorView.Year_of_birth), Convert.ToInt32(authorView.Year_of_death));
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
            if (authorValidator.ValidateFirstname(authorView.Firstname) && authorValidator.ValidatePreposition(authorView.Preposition) && authorValidator.ValidateLastname(authorView.Lastname) && authorValidator.ValidateCity(authorView.City) && authorValidator.ValidateYearofbirth(authorView.Year_of_birth) && authorValidator.ValidateYearofdeath(authorView.Year_of_death))
            {
                Author author = AuthorViewToAuthor(authorView);
                authorContainer.AddAuthor(author);
                ModelState.AddModelError("Succes", "de auteur is toegevoegd!");
                return View("AuthorToevoegen");
            }
            else
            {
                ModelState.AddModelError("Alert", authorValidator.Result);
                return View("AuthorToevoegen");
            }

        }
    }
}