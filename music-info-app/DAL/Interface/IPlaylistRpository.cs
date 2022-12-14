using music_info_app.Model;

namespace music_info_app.DAL.Interface
{
    public interface IPlaylistRpository:IGenericRepository<Playlist>
    {
        IQueryable<Playlist> GetByName(string name);
    }
}
