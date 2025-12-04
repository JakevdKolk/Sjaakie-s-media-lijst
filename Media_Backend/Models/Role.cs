using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
