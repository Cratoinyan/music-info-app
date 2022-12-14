using music_info_app.Entities;

namespace music_info_app.DAL.Interface
{
    public interface IArtistRepository:IGenericRepository<Artist>
    {
        IQueryable<Artist> GetByName(string name);
    }
}
