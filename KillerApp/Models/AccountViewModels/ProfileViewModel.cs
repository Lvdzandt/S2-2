using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Models.AccountViewModels
{
    public class ProfileViewModel
    {
        public User user { get; set; }
        public List<Speedrun> Speedruns { get; set; }
    }
}
