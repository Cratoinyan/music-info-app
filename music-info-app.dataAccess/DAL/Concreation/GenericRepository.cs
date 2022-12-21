using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Entities;

namespace music_info_app.DAL.Concreation
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseEntity
    {
        protected SongContext songContext;

        public GenericRepository(SongContext songContext)
        {
            this.songContext = songContext;
        }
        public IQueryable<TModel> GetAll()
        {
            return songContext.Set<TModel>().AsNoTracking();
        }
        public async Task<TModel> GetByID(int id)
        {
            return await songContext.Set<TModel>().AsNoTracking().FirstAsync(e => e.Id == id);
        }
        public async Task<TModel> Create(TModel model)
        {
            await songContext.Set<TModel>().AddAsync(model);
            await songContext.SaveChangesAsync();
            return model;
        }
        public async Task<TModel> Update(int id, TModel model)
        {
            songContext.Set<TModel>().Update(model);
            await songContext.SaveChangesAsync();
            return model;
        }
        public async Task<TModel> Delete(int id)
        {
            var model = await GetByID(id);
            songContext.Set<TModel>().Remove(model);
            await songContext.SaveChangesAsync();
            return model;
        }
    }
}
