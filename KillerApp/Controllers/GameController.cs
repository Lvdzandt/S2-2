using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Handler;
using KillerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class GameController : Controller
    {
        GameHandler _game = new GameHandler();

        
        public IActionResult Index()
        {
            //LoginViewModel model = new LoginViewModel();
            GameViewModel model = new GameViewModel();
            model.Game = _game.GetAllGames();
            return View(model);
        }

        public IActionResult Game()
        {
            GameViewModel model = new GameViewModel();
            model.Game = _game.GetAllGames();
            return View(model);
        }

    }
}