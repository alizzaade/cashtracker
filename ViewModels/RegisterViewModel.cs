using System.ComponentModel.DataAnnotations;

namespace cashTracker.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(64, MinimumLength = 8, ErrorMessage = "Password must be at least {0} and maximum {1} length!")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
