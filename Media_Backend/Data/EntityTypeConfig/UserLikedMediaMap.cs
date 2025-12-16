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
        }
    }
}
