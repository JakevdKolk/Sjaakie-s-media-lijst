using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class MediaTypeMap : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> builder)
        {
            builder.HasKey(mt => mt.Id);
            builder.Property(mt => mt.Code)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(mt => mt.Label)
               .IsRequired()
               .HasMaxLength(50);

            builder.HasMany(mt => mt.Media)
                .WithOne(m => m.Type)
                .HasForeignKey(m => m.TypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
