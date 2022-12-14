using music_info_app.Model;

namespace music_info_app.DAL.Interface
{
    public interface IUserRepository:IGenericRepository<User>
    {
        Task<IQueryable<User>> GetByName(string username);
        Task<IQueryable<User>> GetByEmail(string email);
    }
}
