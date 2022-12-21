using music_info_app.Entities;

namespace music_info_app.DAL.Interface
{
    public interface IGenericRepository<TModel> where TModel : BaseEntity
    {
        IQueryable<TModel> GetAll();
        Task<TModel> GetByID(int id);
        Task<TModel> Create(TModel model);
        Task<TModel> Update(int id, TModel model);
        Task<TModel> Delete(int id);
    }
}
