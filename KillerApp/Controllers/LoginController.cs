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
        public IActionResult Login(LoginViewModel model)
        {
            if (account.CheckLogin(model.user.Username,model.user.Password))
            {
                User CurrentUser = account.GetAccount(model.user.Username);
                //HttpContext.Session.SetInt32(SessionKeyId, CurrentUser.ID);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}