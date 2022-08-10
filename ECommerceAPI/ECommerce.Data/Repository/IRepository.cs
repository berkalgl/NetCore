using ECommerce.Entities;

namespace ECommerce.Data.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task Create(T entity);
        Task Update(T entity);
    }
}
