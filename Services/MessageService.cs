using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core;
using Core.Domain;
using Services.Dto;
using Services.Interfaces;

namespace Services
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MessageService(IUnitOfWork unitOfWork,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper=mapper;
        }
        public async Task AddMessageAsync(NewMessageDto newMessage)
        {
            var messageToAdd = _mapper.Map<Message>(newMessage);

            _unitOfWork.Messages.Add(messageToAdd);
            await _unitOfWork.Complete();
        }

        public async Task<IReadOnlyList<MessageListDto>> GetAllMessageAsync(string param)
        {
            var messageList = await _unitOfWork.Messages.GetAllAsync();
            var listToFilter = messageList.Where(x => x.Sender.ToLower() == param.ToLower()).ToList();
            var messagesToReturn = _mapper.Map<IReadOnlyList<Message>, IReadOnlyList<MessageListDto>>(listToFilter);

            return messagesToReturn;
        }
    }
}