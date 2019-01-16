using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace KillerApp.Objects
{
    public class User
    {
        public int ID { get; set; }
        [DisplayName("Username :  ")]
        public string Username { get; set; }
        [DisplayName("Password :  ")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Email :  ")]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [DisplayName("Country :  ")]
        public string Country { get; set; }
        [DisplayName("BirthDate :  ")]
        public DateTime date { get; set; }

        public User()
        {

        }
        public User(int _id, string _username,string _email, string _country, DateTime _date)
        {
            ID = _id;
            Username = _username;
            Email = _email;
            Country = _country;
            date = _date;
        }
    }
}
