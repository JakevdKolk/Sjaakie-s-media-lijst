using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data.EntityTypeConfig;

namespace backend.Data
{
    public class MediaListDbContext : DbContext
    {

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Friend> Friends => Set<Friend>();
        public DbSet<MediaType> MediaTypes => Set<MediaType>();
        public DbSet<Media> Media => Set<Media>();
        public DbSet<RelatedMedia> RelatedMedia => Set<RelatedMedia>();
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<MediaCharacter> MediaCharacters => Set<MediaCharacter>();
        public DbSet<UserLikedMedia> UserLikedMedia => Set<UserLikedMedia>();


        public MediaListDbContext(DbContextOptions<MediaListDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap().Configure(modelBuilder.Entity<User>());
            new RoleMap().Configure(modelBuilder.Entity<Role>());
            new FriendMap().Configure(modelBuilder.Entity<Friend>());
            new MediaTypeMap().Configure(modelBuilder.Entity<MediaType>());
            new MediaMap().Configure(modelBuilder.Entity<Media>());
            new RelatedMediaMap().Configure(modelBuilder.Entity<RelatedMedia>());
            new CharacterMap().Configure(modelBuilder.Entity<Character>());
            new MediaCharacterMap().Configure(modelBuilder.Entity<MediaCharacter>());
            new UserLikedMediaMap().Configure(modelBuilder.Entity<UserLikedMedia>());
            base.OnModelCreating(modelBuilder);

        }
    }   
}
