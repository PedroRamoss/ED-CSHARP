using AcademicSocialNetwork.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicSocialNetwork.Infra
{
    public class AcademicSocialNetworkDbContext : DbContext
    {
        public AcademicSocialNetworkDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserConnection> UserConnections { get; set; }

    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserConnection>()
                .HasKey(uc => new { uc.UserId, uc.ConnectedUserId });

            modelBuilder.Entity<UserConnection>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.Connections)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserConnection>()
                .HasOne(uc => uc.ConnectedUser)
                .WithMany()
                .HasForeignKey(uc => uc.ConnectedUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
