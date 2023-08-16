using AutoMapper;
using TestSite1.Application.Responses.Audit;
using TestSite1.Infrastructure.Models.Audit;

namespace TestSite1.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}