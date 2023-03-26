using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Core.Domain;
using Services.Dto;
using Services.Interfaces;

namespace Services
{
    public class MessageService : IMessageService
  {
    private readonly IUnitOfWork _unitOfWork;

    public MessageService(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    public async Task AddMessageAsync(NewMessageDto newMessage)
    {
      _unitOfWork.Messages.Add(new Message() { Text = "Hi Good Morning", Sender = "Web" });
      await _unitOfWork.Complete();

    }

    public async Task<IReadOnlyList<MessageListDto>> GetAllMessageAsync(string param)
    {
      var messageList = await _unitOfWork.Messages.GetAllAsync();

      return new List<MessageListDto>();
    }
  }
}