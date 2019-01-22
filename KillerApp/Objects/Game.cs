using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class Game
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Required Name for game")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required a Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Required a ConsoleName")]
        public string Console { get; set; }
        public Leaderbord Leaderbord { get; set; }
    }
}
