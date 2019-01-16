using KillerApp.Data.Repository;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Handler
{
    public class GameHandler
    {
        GameRepository gameRepository = new GameRepository();
        public GameHandler()
        {

        }
        public int GetRunID(string name)
        {
            return gameRepository.GetRunID(name);
        }

        public List<Game> GetAllGames()
        {
            List<Game> Gamelist = new List<Game>();
            //Gamelist.Add(new Game() { ID = 1,Leaderbord = new Leaderbord() { ID = 1, GameID = 1, Speedruns = new List<Speedrun>() { new Speedrun() { Player= "Test", Hours = 2} } }, Name = "test"});
            Gamelist = gameRepository.GetAllGames();
            return Gamelist;
        }

        public void AddRun(Speedrun speedrun)
        {
            gameRepository.AddRun(speedrun);
        }

        public List<Speedrun> GetUserSpeedruns(int id)
        {
            return gameRepository.GetUserSpeedruns(id);
        }

        public void AddGame(Game game)
        {
            gameRepository.AddGame(game);
        }

        public void AddLeaderBoardRun(int lbid, int runid)
        {
            gameRepository.AddLeaderBoardRun(lbid, runid);
        }

        public Leaderbord GetLeaderbord(int id)
        {
            return gameRepository.GetLeaderbord(id);
        }

        public List<Speedrun> GetAllSpeedruns(int id)
        {
            return gameRepository.GetAllSpeedruns(id);
        }

        public Game GetGame(int id)
        {
            return gameRepository.GetGame(id);
        }
    }
}
