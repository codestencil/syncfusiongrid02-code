using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp6.DAL
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> UpdateAsync(T entity);
        Task<int> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}

