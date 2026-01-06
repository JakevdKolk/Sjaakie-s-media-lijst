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
            builder.HasData(
                new Media { Id = 1, Name = "One Piece", Description = "A story about pirates", TypeId = 1, ReleaseDate = new DateOnly(1999, 10, 20) },
                new Media { Id = 2, Name = "Berserk", Description = "A story about two gay men", TypeId = 1, ReleaseDate = new DateOnly(1997, 10, 26) },
                new Media { Id = 3, Name = "Stardew valley", Description = "A dating sim for a ginger", TypeId = 2, ReleaseDate = new DateOnly(2016, 2, 26) },
                new Media { Id = 4, Name = "Persona 3", Description = "A game about highschoolers fighting shadows", TypeId = 2, ReleaseDate = new DateOnly(2006, 7, 13) },
                new Media { Id = 5, Name = "Persona 3 reload", Description = "A game about highschoolers fighting shadows in a newer coat of paint", TypeId = 2, ReleaseDate = new DateOnly(2024, 2, 2) }
                );

        }
    }
}
