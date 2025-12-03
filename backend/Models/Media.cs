using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int TypeId { get; set; }

        public DateOnly ReleaseDate { get;  set; }
        public DateTime CreatedAt { get; set; }


        public MediaType? Type { get; set; }

        public ICollection<MediaCharacter> MediaCharacters { get; set; } = new List<MediaCharacter>();
        public ICollection<UserLikedMedia> UserLikes { get; set; } = new List<UserLikedMedia>();

        public ICollection<RelatedMedia> Spinoffs { get; set; } = new List<RelatedMedia>();      //main_media
        public ICollection<RelatedMedia> SpinoffOf { get; set; } = new List<RelatedMedia>();     //spinoff_media
    }
}
