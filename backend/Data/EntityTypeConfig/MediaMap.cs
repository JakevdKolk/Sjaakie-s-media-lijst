using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class MediaMap : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(m => m.Description)
                .HasMaxLength(1000);
            builder.Property(m => m.ReleaseDate);
            builder.Property(m => m.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.HasOne(m => m.Type)
                .WithMany(mt => mt.Media)
                .HasForeignKey(m => m.TypeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Spinoffs)
                .WithOne(f => f.MainMedia)
                .HasForeignKey(f => f.MainMediaId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
