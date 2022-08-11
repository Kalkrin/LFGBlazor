using System.ComponentModel.DataAnnotations;

namespace LFGWebApp{
    public class UpdateUserDto  
    {
        [Required, MaxLength(50), MinLength(5)]
        public string Username { get; set; }
        [Required, EmailAddress,]
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