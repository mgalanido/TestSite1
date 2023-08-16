using AutoMapper;
using TestSite1.Application.Interfaces.Chat;
using TestSite1.Application.Models.Chat;
using TestSite1.Infrastructure.Models.Identity;

namespace TestSite1.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}