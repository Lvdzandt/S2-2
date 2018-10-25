using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class Speedrun
    {
        public string Category { get; set; }
        public string Player { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Secondes { get; set; }
        public string VideoLink { get; set; }
        public string Description { get; set; }
    }
}
