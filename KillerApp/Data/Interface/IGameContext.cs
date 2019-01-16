using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Interface
{
    public interface IGameContext
    {
        List<Game> GetAllGames();

        void AddGame(Game game);
        List<Speedrun> GetUserSpeedruns(int id);
        Leaderbord GetLeaderbord(int id);

        List<Speedrun> GetAllSpeedruns(int id);

        Game GetGame(int id);
        void AddRun(Speedrun speedrun);
        void AddLeaderBoardRun(int id, int id2);
        int GetRunID(string name);
    }
}
