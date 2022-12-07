using music_info_app.Model;

namespace music_info_app.DAL
{
    public interface IGenericRepository<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> GetAll();
        Task<TModel> GetByID(int id);
        Task Create(TModel model);
        Task<TModel> Update(int id, TModel model);
        Task<TModel> Delete(int id);
    }
}
