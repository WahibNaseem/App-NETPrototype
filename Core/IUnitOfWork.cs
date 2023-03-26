using System;
using System.Threading.Tasks;
using Core.Reoositories;

namespace Core
{
    public interface IUnitOfWork : IDisposable
  {
    IMessageRepository Messages { get; set; }
    Task<int> Complete();
  }
}