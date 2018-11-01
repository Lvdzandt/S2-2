using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Handler;
using KillerApp.Models;
using KillerApp.Objects;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class GameController : Controller
    {
        GameHandler _game = new GameHandler();

        
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            //LoginViewModel model = new LoginViewModel();
            GameViewModel model = new GameViewModel();
            model.Game = _game.GetAllGames();
            return View(model);
        }

        public IActionResult Game(GameViewModel model)
        {
            model.Game = _game.GetAllGames();
            //model.Leaderbord = _game.GetLeaderbord(1);
            return View(model);
        }

        
        public IActionResult AddGame()
        {
            AddGameViewModel model = new AddGameViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddGame(AddGameViewModel newGame)
        {
            if (true)
            {
                _game.AddGame(newGame.Game);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}