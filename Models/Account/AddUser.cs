using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Account
{
    public class AddUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password confirm field must be a minimum of 6 characters")]
        public string Password_conf { get; set; }

    }
}