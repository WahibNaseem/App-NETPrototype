using AutoMapper;
using Core.Domain;
using Services.Dto;

namespace Services.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Message, MessageListDto>().ReverseMap();
            CreateMap<Message, NewMessageDto>().ReverseMap();
        }
    }
}
