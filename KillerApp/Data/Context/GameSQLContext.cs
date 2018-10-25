using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class GameSQLContext : IGameContext
    {
        public List<Game> GetAllGames()
        {
            return new List<Game>();
        }

        public void AddGame(Game game)
        {

        }
    }
}
