using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Models
{
    public class AllGameViewModel
    {
        public List<Game> Game { get; set; }
        public Leaderbord Leaderbord { get; set; }
        public int id { get; set; }
    }
}
