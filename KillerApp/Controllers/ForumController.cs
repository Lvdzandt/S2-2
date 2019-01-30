using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Logic;
using KillerApp.Models.ForumViewModels;
using KillerApp.Models.GameViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class ForumController : Controller
    {
        ForumLogic _log = new ForumLogic();
        public IActionResult Index()
        {
            ForumViewModel model = new ForumViewModel();
            model.posts = _log.GetAllForumPosts();
            return View(model);
        }

        public IActionResult NewPost()
        {
            ForumPostViewModel model = new ForumPostViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult NewPost(ForumPostViewModel model)
        {
            _log.AddPost(model.post);
            return View();
        }
    }
}