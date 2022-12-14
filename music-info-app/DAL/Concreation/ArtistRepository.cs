using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.DAL.Concreation
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(SongContext songContext) : base(songContext) { }
        public IQueryable<Artist> GetByName(string name)
        {
            return songContext.Artists.Where(x => x.Name == name);
        }
    }
}
