using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class Leaderbord
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public List<Speedrun> Speedruns { get; set; }
    }
}
