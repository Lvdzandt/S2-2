using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Handler;
using KillerApp.Logic;
using KillerApp.Models;
using KillerApp.Models.GameViewModels;
using KillerApp.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KillerApp.Controllers
{
    public class GameController : Controller
    {
        GameHandler _game = new GameHandler();
        AccountLogic account = new AccountLogic();

        
        public IActionResult Index()
        {
            
            //LoginViewModel model = new LoginViewModel();
            AllGameViewModel model = new AllGameViewModel();
            model.Game = _game.GetAllGames();
            foreach (var item in model.Game)
            {
                item.Leaderbord = _game.GetLeaderbord(item.ID);
                item.Leaderbord.Speedruns = _game.GetAllSpeedruns(item.Leaderbord.ID);
            }
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


        //trigger op db zodra run word toegevoegd
        public IActionResult AddRun(int id)
        {
            AddRunViewModel model = new AddRunViewModel();
            model.LeaderboardID = id;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddRun(AddRunViewModel output)
        {
            int id = 0;
            var sessionName = new Byte[20];
            bool nameOK = HttpContext.Session.TryGetValue("_Name", out sessionName);
            string result = System.Text.Encoding.UTF8.GetString(sessionName);
            User curruser = account.GetAccount(result);
            output.speedRun.Hours = Convert.ToInt32(output.time.Substring(0, 2));
            output.speedRun.Minutes = Convert.ToInt32(output.time.Substring(3));
            output.speedRun.PlayerID = curruser.ID;
            _game.AddRun(output.speedRun);
            while (id == 0)
            {
                id = _game.GetRunID(output.speedRun.Player);
            }
            _game.AddLeaderBoardRun(output.LeaderboardID, id);
            //output.speedRun.PlayerID = 
            return RedirectToAction("Index");
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