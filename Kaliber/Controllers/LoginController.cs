using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Repository;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;

namespace Kaliber.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;
        LoginRepository _LoginRepo;
        public LoginController(IConfiguration config)
        {
            this.configuration = config;
            _LoginRepo = new LoginRepository(configuration);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            _LoginRepo.Login(user);
            return View();
        }
    }


}