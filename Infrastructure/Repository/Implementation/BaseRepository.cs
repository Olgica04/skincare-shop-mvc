using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class BaseRepository<T>
        : IRepository<T> where T : class, IBaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T? GetById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<T> Query()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }
        public T Create(T entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public T Update(T entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public T Delete(T entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}