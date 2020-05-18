using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Repository;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;
using Kaliber.Interfaces;

namespace Kaliber.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;
        ILoginRepository iloginRepository;
        public LoginController(IConfiguration config, ILoginRepository iloginRepository)
        {
            this.iloginRepository = iloginRepository;
            this.configuration = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool Login(UserView user)
        {
           return user.LoggedIn = iloginRepository.Exists(user);
        }
    }


}