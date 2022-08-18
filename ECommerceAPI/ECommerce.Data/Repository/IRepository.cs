using ECommerce.Entities;

namespace ECommerce.Data.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IList<T>> GetAll();
        Task Create(T entity);
        Task Update(T entity);
        Task<T> GetEntity(int id);
    }
}
