using AutoMapper;
using TestSite1.Application.Responses.Identity;
using TestSite1.Infrastructure.Models.Identity;

namespace TestSite1.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}