using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Handler;
using KillerApp.Models;
using KillerApp.Models.GameViewModels;
using KillerApp.Objects;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class GameController : Controller
    {
        GameHandler _game = new GameHandler();

        
        public IActionResult Index()
        {
            
            //LoginViewModel model = new LoginViewModel();
            AllGameViewModel model = new AllGameViewModel();
            model.Game = _game.GetAllGames();
            return View(model);
        }

        
        public IActionResult Game(int id)
        {
            GameViewModel model = new GameViewModel();
            model.game = _game.GetGame(id);
            model.leaderbord = _game.GetLeaderbord(id);
            model.leaderbord.Speedruns = _game.GetAllSpeedruns(model.leaderbord.ID);
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
            if (newGame.Game.Name != null)
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