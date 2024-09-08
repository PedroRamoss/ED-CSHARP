namespace AcademicSocialNetwork.Domain.Models
{
    public class UserConnection
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ConnectedUserId { get; set; }
        public User ConnectedUser { get; set; }
    }
}
