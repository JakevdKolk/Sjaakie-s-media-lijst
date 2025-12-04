namespace backend.Models
{
    public class RelatedMedia
    {
        public int MainMediaId { get; set; }
        public int SpinoffMediaId { get; set; }

        public string RelationType { get; set; } = string.Empty;

        public Media? MainMedia { get; set; }
        public Media? SpinoffMedia { get; set; }
    }
}
