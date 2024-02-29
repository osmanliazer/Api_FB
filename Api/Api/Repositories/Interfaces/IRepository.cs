using Api.Entities;
using System.Linq.Expressions;

namespace Api.Repositories.Interfaces
{
    public interface IRepository<T>where T:BaseEntity,new()
    {
        Task<IQueryable<T>> GetAll(params srting[] inculudes);
        Task AddAsync(T item);
        void Update(T item);
        void Delete(T item);    
        Task SaveChangesAsync();
    }
}
