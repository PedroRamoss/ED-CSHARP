namespace AcademicSocialNetwork.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserConnection> Connections { get; set; }
        public ICollection<Publication> Publications { get; set; }
    }
}
