using Microsoft.EntityFrameworkCore;
using music_info_app.Model;
using System.Data;

namespace music_info_app.DB
{
    public class SongContext:DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options) { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistPassword> ArtistsPassword { get; set; }
        public DbSet<BugLog> BugLog { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPassword> UserPassword { get; set; }
    }
}
