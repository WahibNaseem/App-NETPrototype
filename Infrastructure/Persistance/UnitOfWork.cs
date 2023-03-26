using System.Threading.Tasks;
using Core;
using Core.Reoositories;
using Infrastructure.Persistance.Contexts;
using Infrastructure.Repositories;

namespace Infrastructure.Persistance
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly MessageContext _context;
    public UnitOfWork(MessageContext context)
    {
      _context = context;
      Messages = new MessageRepository(_context);

    }
    public IMessageRepository Messages { get; set; }

    public Task<int> Complete()
    {
      return _context.SaveChangesAsync();
    }

    public void Dispose()
    {
      _context.Dispose();
    }
  }
}