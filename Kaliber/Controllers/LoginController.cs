using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;

namespace Kaliber.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;
        public LoginController(IConfiguration config)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }


}