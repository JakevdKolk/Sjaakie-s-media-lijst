using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        public int RoleId { get; set; }

        public DateTime CreatedAt { get; set; }

        public Role? Role { get; set; }

        public ICollection<Friend> Friends { get; set; } = new List<Friend>();          // users this user added as friend
        public ICollection<Friend> FriendOf { get; set; } = new List<Friend>();        // users who added this user

        public ICollection<UserLikedMedia> LikedMedia { get; set; } = new List<UserLikedMedia>();

    }
}
