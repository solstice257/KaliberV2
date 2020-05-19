using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kaliber.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IConfiguration configuration;

        public RegisterController(IConfiguration config)
        {
        }

        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }
    }
}
