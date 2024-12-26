using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionCommandes.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
    }
}