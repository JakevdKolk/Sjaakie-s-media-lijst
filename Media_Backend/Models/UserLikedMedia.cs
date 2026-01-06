namespace backend.Models
{
    public class UserLikedMedia
    {
        public int UserId { get; set; }
        public int MediaId { get; set; }

        public int Score { get; set; }
        public string Status { get; set; } = string.Empty;

        public DateTimeOffset? StartedAt { get; set; }
        public DateTimeOffset? CompletedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public User? User { get; set; }
        public Media? Media { get; set; }
    }
}
