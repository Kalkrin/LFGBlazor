using System.ComponentModel.DataAnnotations;

namespace LFGWebApp
{
    public class UpdateGameDto
    {
        [Required, MaxLength(50), MinLength(5)]
        public string Name { get; set; }
        [Required, MaxLength(5000)]
        public string Description { get; set; }
        [Required, Url, MaxLength(500)]
        public string Thumbnail { get; set; }
        public List<int> PlayersToAdd { get; set; }
        public List<int> PlayersToRemove { get; set; }
    }
}