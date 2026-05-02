using System.ComponentModel.DataAnnotations;
namespace IdentityDemo.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(
          @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
          ErrorMessage = "Password must contain uppercase, lowercase, number and be 8+ chars.")]
        public string Password { get; set; }
    }
}
