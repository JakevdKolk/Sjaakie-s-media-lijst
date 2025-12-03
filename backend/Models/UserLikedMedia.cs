namespace backend.Models
{
    public class UserLikedMedia
    {
        public int UserId { get; set; }
        public int MediaId { get; set; }

        public int Score { get; set; }
        public string Status { get; set; } = string.Empty;

        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User? User { get; set; }
        public Media? Media { get; set; }
    }
}
