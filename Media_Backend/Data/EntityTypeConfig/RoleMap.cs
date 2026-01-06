using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.EntityTypeConfig
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" },
                new Role { Id = 3, Name = "Moderator" },
                new Role { Id = 4, Name = "Editor" }
                );
        }
    }
}
