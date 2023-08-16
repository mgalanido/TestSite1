using AutoMapper;
using TestSite1.Application.Features.Documents.Commands.AddEdit;
using TestSite1.Application.Features.Documents.Queries.GetById;
using TestSite1.Domain.Entities.Misc;

namespace TestSite1.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}