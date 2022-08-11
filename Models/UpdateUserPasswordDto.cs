using System.ComponentModel.DataAnnotations;

namespace LFGWebApp
{
    public class UpdateUserPasswordDto
    {
        [Required]
        public string ExistingPassword { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string NewPassword { get; set; }
    }
}
