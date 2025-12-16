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
            builder.HasMany(m => m.Spinoffs)
                .WithOne(mm => mm.MainMedia)
                .HasForeignKey(mm => mm.MainMediaId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(m => m.SpinoffOf)
                .WithOne(mm => mm.SpinoffMedia)
                .HasForeignKey(mm => mm.SpinoffMediaId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(m => m.MediaCharacters)
                .WithOne(mc => mc.Media)
                .HasForeignKey(mc => mc.MediaId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(m => m.UserLikes)
                .WithOne(ulm => ulm.Media)
                .HasForeignKey(ulm => ulm.MediaId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
