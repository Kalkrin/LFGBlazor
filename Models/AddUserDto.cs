using System.ComponentModel.DataAnnotations;

namespace LFGWebApp
{
     public class AddUserDto
    {
        [Required, MaxLength(50), MinLength(5)]
        public string Username { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string Password { get; set; }
        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(5000)]
        public string Bio { get; set; }
        [Required, MaxLength(500), Url]
        public string ProfilePicture { get; set; }

    }
}