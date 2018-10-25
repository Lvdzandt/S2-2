using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class LoginController : Controller
    {
        private object loginviewmodel;

        public IActionResult Index()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Auterize(KillerApp.Models.LoginViewModel model)
        {
            return View();
        }
    }
}