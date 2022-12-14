using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Entities;

namespace music_info_app.DAL.Concreation
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(SongContext songContext) : base(songContext) { }
        public IQueryable<Album> GetBySonCount(int count)
        {
            return songContext.Albums.Where(x => x.SongCount == count);
        }
        public IQueryable<Album> GetAll()
        {
            return songContext.Set<Album>().AsNoTracking().Include(a => a.Songs);
        }

        public async Task<Album> GetByID(int id)
        {
            return await songContext.Set<Album>().AsNoTracking().Include(a => a.Songs).FirstAsync(e => e.Id == id);
        }
    }
}
