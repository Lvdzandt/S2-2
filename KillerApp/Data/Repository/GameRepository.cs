using KillerApp.Data.Context;
using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Repository
{
    public class GameRepository
    {
        IGameContext gameContext = new GameSQLContext();

        public void AddGame(Game game)
        {
            gameContext.AddGame(game);
        }

        public List<Game> GetAllGames()
        {
            return gameContext.GetAllGames();
        }
    }
}
