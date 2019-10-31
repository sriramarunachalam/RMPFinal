using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static RmgAPI.Models.User;

namespace RmgAPI.DTOs
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "This is a required field, please enter email.")]
        [EmailAddress(ErrorMessage = "Should be in the form abc@xyz.com.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This is a required field, please enter password.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 15 characters.")]
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
