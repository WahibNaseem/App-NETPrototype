using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Repositories;
using Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    protected readonly MessageContext _messageContext;
    public Repository(MessageContext messageContext)
    {
      _messageContext = messageContext;

    }
    public void Add(TEntity entity)
    {
      _messageContext.Set<TEntity>().Add(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
      return await _messageContext.Set<TEntity>().ToListAsync();
    }
  }
}