using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class FriendMap : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.HasKey(f => new { f.UserId, f.FriendId });
            builder.Property(f => f.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.HasData(
                new Friend { UserId = 1, FriendId = 2 },
                new Friend { UserId = 1, FriendId = 3 },
                new Friend { UserId = 2, FriendId = 3 }
            );
        }
    }
}
