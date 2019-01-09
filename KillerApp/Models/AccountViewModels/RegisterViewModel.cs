using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Middle Name")]
        public string middleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        


        [Display(Name = "Function")]
        public string function { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Rockstar Since")]
        public DateTime RockstarSince { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Profile Image")]
        public IFormFile ProfileImage { get; set; }
    }
}
