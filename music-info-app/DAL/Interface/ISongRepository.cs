using music_info_app.Model;

namespace music_info_app.DAL.Interface
{
    public interface ISongRepository:IGenericRepository<Song>
    {
        IQueryable<Song> GetByTitle(string title);
        IQueryable<Song> GetByDuration(int seconds);
        IQueryable<Song> GetByListenerCount(int count);
    }
}
