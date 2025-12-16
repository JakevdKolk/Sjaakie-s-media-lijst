namespace backend.Models
{
    public class Friend
    {
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime CreatedAt { get; set; }

        public User? User { get; set; }        
        public User? FriendUser { get; set; } 
    }
}
