using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<MediaCharacter> MediaCharacters { get; set; } = new List<MediaCharacter>();
    }
}
