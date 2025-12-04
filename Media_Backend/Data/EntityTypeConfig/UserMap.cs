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
        }
    }

}
