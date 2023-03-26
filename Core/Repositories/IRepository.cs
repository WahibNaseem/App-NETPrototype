using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
  {
    Task<IEnumerable<TEntity>> GetAllAsync();
    void Add(TEntity entity);

  }
}