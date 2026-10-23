using CustomerPortal.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustomerPortal.Shared.Entities
{
    public class User: IdentityUser
    {
        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "Field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last name")]
        [MaxLength(50, ErrorMessage = "Field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "Field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string Address { get; set; } = null!;

        [DefaultValue("+964")]
        [Display(Name = "Country Code")]
        [MaxLength(5, ErrorMessage = "The {0} field cannot be longer than {1} characters.")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public string CountryCode { get; set; } = null!;

        [Display(Name = "Photo")]
        public string? Photo { get; set; }

        [Display(Name = "User type")]
        public UserType UserType { get; set; }

        [Display(Name = "User type")]
        public UserStatus UserStatus { get; set; } = UserStatus.Pending;    

        [Display(Name = "User")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
