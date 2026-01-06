using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class UserLikedMediaMap : IEntityTypeConfiguration<UserLikedMedia>
    {
        public void Configure(EntityTypeBuilder<UserLikedMedia> builder)
        {
            builder.HasKey(ulm => new { ulm.UserId, ulm.MediaId });

            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(x => x.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            var seedTime = new DateTime(2026, 1, 6, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new UserLikedMedia
                {
                    UserId = 1,
                    MediaId = 1,
                    Score = 10,
                    Status = "Completed",
                    StartedAt = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CompletedAt = new DateTime(2020, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedAt = seedTime,
                    UpdatedAt = seedTime
                },
                new UserLikedMedia
                {
                    UserId = 2,
                    MediaId = 3,
                    Score = 10,
                    Status = "Playing",
                    StartedAt = new DateTime(2016, 1, 2, 0, 0, 0, DateTimeKind.Utc),
                    CompletedAt = null,
                    CreatedAt = seedTime,
                    UpdatedAt = seedTime
                }
            );

        }
    }
}
