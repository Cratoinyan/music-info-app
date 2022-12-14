using Microsoft.EntityFrameworkCore;
using music_info_app.Entities;
using System.Data;

namespace music_info_app.DB
{
    public class SongContext:DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options) { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
