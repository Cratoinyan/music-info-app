using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Entities;

namespace music_info_app.DAL.Concreation
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(SongContext songContext) : base(songContext) { }
        public IQueryable<Artist> GetByName(string name)
        {
            return songContext.Artists.Where(x => x.Name == name);
        }
        public IQueryable<Artist> GetAll()
        {
            return songContext.Set<Artist>().AsNoTracking().Include(a => a.Albums).ThenInclude(a => a.Songs);
        }
        public async Task<Artist> GetByID(int id)
        {
            return await songContext.Set<Artist>().AsNoTracking().Include(a => a.Albums).ThenInclude(a => a.Songs).FirstAsync(e => e.Id == id);
        }
    }
}
