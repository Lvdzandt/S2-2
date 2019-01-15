using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Models.GameViewModels
{
    public class AddRunViewModel
    {
        public Speedrun speedRun { get; set; }
        public int LeaderboardID { get; set; }
        public string time { get; set; }
    }
}
