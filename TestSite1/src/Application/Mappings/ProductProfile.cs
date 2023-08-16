using AutoMapper;
using TestSite1.Application.Features.Products.Commands.AddEdit;
using TestSite1.Domain.Entities.Catalog;

namespace TestSite1.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}