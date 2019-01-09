using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Data.Repository;
using KillerApp.Logic;
using KillerApp.Models;
using KillerApp.Objects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Session;
using System.Web;
using KillerApp.Models.AccountViewModels;

namespace KillerApp.Controllers
{
    public class LoginController : Controller
    {
        //private object loginviewmodel;
        private AccountLogic account = new AccountLogic();
        public const string SessionKeyName = "_Name";
        public const string SessionKeyId = "UserID";

        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (account.CheckLogin(model.user.Username,model.user.Password))
            {

                User CurrentUser = account.GetAccount(model.user.Username);
                HttpContext.Session.SetString(SessionKeyName, CurrentUser.Username);
                Console.WriteLine(HttpContext.Session.GetString(SessionKeyName));
                Console.WriteLine(HttpContext.Session.GetInt32("UserID"));
                currlogin.name = model.user.Username;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        public IActionResult Profile()
        {
            var sessionName = new Byte[20];
            bool nameOK = HttpContext.Session.TryGetValue("_Name", out sessionName);
            string result = System.Text.Encoding.UTF8.GetString(sessionName);
            ProfileViewModel model = new ProfileViewModel();
            model.user = account.GetAccount(result);
            return View(model);
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}