using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class RelatedMediaMap : IEntityTypeConfiguration<RelatedMedia>
    {
        public void Configure(EntityTypeBuilder<RelatedMedia> builder)
        {
            builder.HasKey(rm => new { rm.MainMediaId, rm.SpinoffMediaId });
            builder.HasData(
                new RelatedMedia { MainMediaId = 4, SpinoffMediaId = 5 }
                );
        }
    }
}
