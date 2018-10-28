using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class ApplicationUser : IdentityUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
