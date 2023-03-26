using System.Collections.Generic;
using System.Threading.Tasks;
using Services.Dto;

namespace Services.Interfaces
{
    public interface IMessageService
  {
    Task<IReadOnlyList<MessageListDto>> GetAllMessageAsync(string param);
    Task AddMessageAsync(NewMessageDto newMessage);
  }
}