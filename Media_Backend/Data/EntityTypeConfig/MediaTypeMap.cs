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

            builder.HasData(
                new MediaType { Id = 1, Code = "ANIME", Label = "Anime" },
                new MediaType { Id = 2, Code = "GAME", Label = "Game" },
                new MediaType { Id = 3, Code = "MANGA", Label = "Manga" },
                new MediaType { Id = 4, Code = "MOVIE", Label = "Movie" },
                new MediaType { Id = 5, Code = "TV_SHOW", Label = "TV Show" },
                new MediaType { Id = 6, Code = "BOOK", Label = "Book" },
                new MediaType { Id = 7, Code = "COMIC", Label = "Comic" },
                new MediaType { Id = 8, Code = "MUSIC", Label = "Music" },
                new MediaType { Id = 9, Code = "PODCAST", Label = "Podcast" },
                new MediaType { Id = 10, Code = "WEB_SERIES", Label = "Web Series" },
                new MediaType { Id = 11, Code = "OTHER", Label = "Other" }

                );
        }
    }
}
