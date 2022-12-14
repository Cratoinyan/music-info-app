using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.DAL.Concreation
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(SongContext songContext) : base(songContext) { }
        public IQueryable<Album> GetBySonCount(int count)
        {
            return songContext.Albums.Where(x => x.SongCount == count);
        }
    }
}
