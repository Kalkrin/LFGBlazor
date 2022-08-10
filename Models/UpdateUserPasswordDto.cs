using System.ComponentModel.DataAnnotations;

namespace LFGWebApp
{
    public class UpdateUserPasswordDto
    {
        [Required]
        public string ExistingPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
