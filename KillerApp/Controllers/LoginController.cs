using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Data.Repository;
using KillerApp.Models;
using KillerApp.Objects;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class LoginController : Controller
    {
        //private object loginviewmodel;
        private AccountRepository account = new AccountRepository();
        public const string SessionKeyName = "_Name";
        public const string SessionKeyId = "UserID";

        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            foreach (User user in account.GetAllAccounts())
            {
                if (user.Username == model.user.Username && user.Password == model.user.Password)
                {
                    
                    return RedirectToAction(nameof(HomeController.Contact), "Home");
                }
            }
            return View();
        }
    }
}