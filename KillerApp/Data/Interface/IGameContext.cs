﻿using KillerApp.Objects;
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
    }
}
