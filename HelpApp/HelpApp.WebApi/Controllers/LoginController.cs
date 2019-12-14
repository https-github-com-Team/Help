using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.WebApi.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}