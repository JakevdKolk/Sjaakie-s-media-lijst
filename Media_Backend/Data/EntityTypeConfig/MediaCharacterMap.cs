using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class MediaCharacterMap : IEntityTypeConfiguration<MediaCharacter>
    {
        public void Configure(EntityTypeBuilder<MediaCharacter> builder)
        {
            builder.HasKey(mc => new { mc.MediaId, mc.CharacterId });
            builder.HasData(
                new MediaCharacter { MediaId = 1, CharacterId = 1 },
                new MediaCharacter { MediaId = 1, CharacterId = 2 },
                new MediaCharacter { MediaId = 2, CharacterId = 3 }
            );
        }
    }

}
