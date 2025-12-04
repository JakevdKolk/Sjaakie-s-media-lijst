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
        }
    }

}
