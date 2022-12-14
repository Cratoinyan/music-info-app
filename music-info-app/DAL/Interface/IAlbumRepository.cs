using music_info_app.Entities;

namespace music_info_app.DAL.Interface
{
    public interface IAlbumRepository: IGenericRepository<Album>
    {
        IQueryable<Album> GetBySonCount(int count);
    }
}
