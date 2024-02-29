using PustokOnion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustokOnion.Aplication.Abstractions.Repositories
{
    public interface IRepositories<T> where T :BaseEntity,new()
    {
        IQueryable<T> GetAll(int skip=0,int take=0,params string[] inculude);
        Task<T>GetByInculudes(int id);
        Task<T> AddAsync(T tag);    
        Task<T> Update(T tag);
        Task<T> Delete(T tag);
        Task SaveChangeAsync();
    }
}
