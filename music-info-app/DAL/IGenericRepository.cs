using music_info_app.Model;

namespace music_info_app.DAL
{
    public interface IGenericRepository<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> GetAll();
        Task<TModel> GetByID(int id);
        Task Create(TModel model);
        Task Update(int id, TModel model);
        Task Delete(int id);
    }
}
