using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Repository;
using Kaliber.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kaliber.Controllers
{
    public class RegisterController : Controller
    {
        private RegisterRepositiory _RegisRepo = new RegisterRepositiory();
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            string Username = user.Username;
            string Password = user.Password;
            string Email = user.Email;

            _RegisRepo.AddUsers(Username, Password, Email);

            return View();
        }
    }
}
