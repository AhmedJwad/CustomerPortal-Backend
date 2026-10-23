using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerPortal.Shared.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Field {0} is required.")]
        //[EmailAddress(ErrorMessage = "You must enter a valid email.")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Field {0} is required.")]
        [MinLength(8, ErrorMessage = "The {0} must be at least 8 characters long and contain at least one uppercase letter," +
            " one lowercase letter, one digit, and one special character")]
        public string Password { get; set; } = null!;
    }
}
