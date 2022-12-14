using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.DAL.Concreation
{
    public class PlaylistRepository : GenericRepository<Playlist>, IPlaylistRpository
    {
        public PlaylistRepository(SongContext songContext) : base(songContext) { }
        public IQueryable<Playlist> GetByName(string name)
        {
            return songContext.Playlists.Where(x => x.Name == name);
        }
    }
}
