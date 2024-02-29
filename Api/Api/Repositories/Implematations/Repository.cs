using Api.DAL;
using Api.Entities;
using Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Api.Repositories.Implematations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        private readonly AppDbContext DbSet<T>_DbSet;
        public Repository (AppDbContext context)
        {
            _context=context;
            _table = context.Set<T>();
        }
        public async Task AddAsync(Tag category)
        {
            await _context.AddAsync(category);
        }

        public void Delete(Tag category)
        {
            _context.Tags.Remove(category);
        }

        public async Task<IQueryable<Tag>> GetAllAsync(Expression<Func<T, bool>>? expression = null, params string[] includes);
       
     
        public async Task<Tag> GetByIdAsync(int id)
        {
            T entity = _table.FirstOrDefaultAsync(c => c.Id == id);    
            return entity;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async void Update(Tag category)
        {
            _context.Tags.Update(category);
        }

    }
}
