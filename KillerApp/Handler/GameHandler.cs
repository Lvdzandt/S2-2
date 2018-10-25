using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Handler
{
    public class GameHandler
    {
        public GameHandler()
        {

        }

        public List<Game> GetAllGames()
        {
            List<Game> Gamelist = new List<Game>();
            Gamelist.Add(new Game() { ID = 1,Leaderbord = new Leaderbord() { ID = 1, GameID = 1, Speedruns = new List<Speedrun>() { new Speedrun() { Player= "Test", Hours = 2} } }, Name = "test"});
            return Gamelist;
        }

    }
}
