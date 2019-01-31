using Objects.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class Speedrun
    {
        public int ID { get; set; }
        [EnumDataType(typeof(GameCategory.Categorie))]
        public GameCategory.Categorie Category { get; set; }
        [Required]
        public string Player { get; set; }
        public int PlayerID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Hours { get; set; }
        [Required]
        public int Minutes { get; set; }
        public int Secondes { get; set; }
        public string VideoLink { get; set; }
        public string Description { get; set; }


        public string GetTime()
        {
            string time = Hours + "h " + Minutes + "m "; //+ Secondes + "s";
            return time;
        }
    }
}
