using AutoMapper;
using TestSite1.Application.Requests.Identity;
using TestSite1.Application.Responses.Identity;

namespace TestSite1.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}