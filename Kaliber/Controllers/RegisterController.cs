using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kaliber.Repository;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;
using Kaliber.Interfaces;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kaliber.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IConfiguration configuration;
        RegisterRepositiory _RegisRepo;
        IRegisterRepository iregisterRepository;
        public RegisterController(IConfiguration config, IRegisterRepository iregisterRepository)
        {
            this.iregisterRepository = iregisterRepository;
            this.configuration = config;
            _RegisRepo = new RegisterRepositiory(configuration);
        }

        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool AddedUser(User user)
        {
           return iregisterRepository.AddedUser(user);
        }
    }
}
