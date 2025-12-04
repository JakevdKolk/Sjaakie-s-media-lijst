namespace backend.Models
{
    public class MediaCharacter
    {
        public int MediaId { get; set; }
        public int CharacterId { get; set; }

        public Media? Media { get; set; }
        public Character? Character { get; set; }
    }
}
