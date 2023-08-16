using AutoMapper;
using TestSite1.Application.Features.DocumentTypes.Commands.AddEdit;
using TestSite1.Application.Features.DocumentTypes.Queries.GetAll;
using TestSite1.Application.Features.DocumentTypes.Queries.GetById;
using TestSite1.Domain.Entities.Misc;

namespace TestSite1.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}