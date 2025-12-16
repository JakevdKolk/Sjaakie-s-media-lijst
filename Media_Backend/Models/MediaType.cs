using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class MediaType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;

        public string Label { get; set; } = string.Empty;

        public ICollection<Media> Media { get; set; } = new List<Media>();
    }
}
