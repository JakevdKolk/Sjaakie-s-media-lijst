using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");  
            builder.HasMany(u => u.Friends)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.FriendOf)
                .WithOne(f => f.FriendUser)
                .HasForeignKey(f => f.FriendId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.LikedMedia)
                .WithOne(ulm => ulm.User)
                .HasForeignKey(ulm => ulm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new User
                {
                    Id = 1,
                    Username = "Jake",
                    Email = "vandekolkjake@gmail.com",
                    RoleId = 1,
                    CreatedAt = new DateTime(2026, 1, 6, 0, 0, 0, DateTimeKind.Utc)
                },
                new User
                {
                    Id = 2,
                    Username = "Delta",
                    Email = "deltatheginger@gmail.com",
                    RoleId = 2,
                    CreatedAt = new DateTime(2026, 1, 6, 0, 0, 0, DateTimeKind.Utc)
                },
                new User
                {
                    Id = 3,
                    Username = "Michmans",
                    Email = "thediscordmod@gmail.com",
                    RoleId = 3,
                    CreatedAt = new DateTime(2026, 1, 6, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }

}
