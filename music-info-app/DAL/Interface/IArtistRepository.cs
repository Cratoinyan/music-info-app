using music_info_app.Model;

namespace music_info_app.DAL.Interface
{
    public interface IArtistRepository:IGenericRepository<Artist>
    {
        IQueryable<Artist> GetByName(string name);
    }
}
