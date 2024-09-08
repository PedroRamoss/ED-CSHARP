namespace AcademicSocialNetwork.Domain.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
