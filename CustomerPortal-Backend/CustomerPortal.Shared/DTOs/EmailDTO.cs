using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerPortal.Shared.DTOs
{
    public class EmailDTO
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress(ErrorMessage = "You must enter a valid email.")]
        public string Email { get; set; } = null!;
    }
}
