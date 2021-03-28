using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Domain
{
    public interface IRepository
    {
        Task<T> GetAsync<T>(int id) where T : class, IBaseEntity;
        Task<IEnumerable<T>> GetAsync<T>(Expression<Func<T, bool>> predicate = null, int? pageNumer = null, int? pageSize = null)
            where T : class, IBaseEntity;
        Task<int> CountAsync<T>(Expression<Func<T, bool>> predicate = null) where T : class, IBaseEntity;
        Task<T> AddAsync<T>(T entity) where T : class, IBaseEntity;
        Task UpdateAsync<T>(T entity) where T : class, IBaseEntity;
        Task DeleteAsync<T>(T entity) where T : class, IBaseEntity;
    }
}
