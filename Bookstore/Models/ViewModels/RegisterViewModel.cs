using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username")]
        [StringLength(255)]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage ="Please enter a first name.")]
        [StringLength(255)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
