using Domain.Entities;

namespace Infrastructure.Repository
{
    public interface IRepository<T> where T : class, IBaseEntity
    {
        T? GetById(int id);
        IQueryable<T> Query();
        T Update(T entity);
        T Delete(T entity);
        T Create(T entity);
    }
}