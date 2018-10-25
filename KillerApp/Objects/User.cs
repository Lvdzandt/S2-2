using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KillerApp.Objects
{
    public class User
    {
        [DisplayName("Username :  ")]
        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }
        [DisplayName("Password :  ")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
