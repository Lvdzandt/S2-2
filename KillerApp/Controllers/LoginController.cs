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

        public IActionResult Index()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Auterize(LoginViewModel model)
        {
            string url = "https://localhost:5001/";
            //foreach (User user in account.GetAllAccounts())
            //{
            //    if (user.Username == model.user.Username && user.Password == model.user.Password)
            //    {
            //        return Redirect(url);
            //    }
            //}
            //return View();
            if (model.user.Username == "test")
            {
                return Redirect(url);
            }
            return View();
        }
    }
}