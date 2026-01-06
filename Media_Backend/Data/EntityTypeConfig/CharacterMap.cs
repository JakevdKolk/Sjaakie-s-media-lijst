using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace backend.Data.EntityTypeConfig
{
    public class CharacterMap : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Description)
                .HasMaxLength(1000);
            builder.HasMany(c => c.MediaCharacters)
                .WithOne(mc => mc.Character)
                .HasForeignKey(mc => mc.CharacterId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Character { Id = 1, Name = "Luffy", Description = "Has stage 4 cancer"},
                new Character { Id = 2, Name = "Guts", Description = "Man is edgy" },
                new Character { Id = 3, Name = "Penny", Description = "Delta simpt voor haar"}
            );
        }
    }
}
