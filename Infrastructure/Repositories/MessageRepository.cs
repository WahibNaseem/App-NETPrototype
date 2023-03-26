using Core.Domain;
using Core.Reoositories;
using Infrastructure.Persistance.Contexts;

namespace Infrastructure.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
  {
    public MessageRepository(MessageContext messageContext) : base(messageContext) { }
  
  }
}