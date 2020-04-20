using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Repository;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kaliber.Controllers
{
    public class RegisterController : Controller
    {
        IConfiguration configuration;
        RegisterRepositiory _RegisRepo;
        public RegisterController(IConfiguration config)
        {
            this.configuration = config;
            _RegisRepo = new RegisterRepositiory(configuration);
        }
        
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Index(User user)
        {
            _RegisRepo.AddUsers(user);
        }
    }
}
