using AutoMapper;
using TestSite1.Application.Features.Brands.Commands.AddEdit;
using TestSite1.Application.Features.Brands.Queries.GetAll;
using TestSite1.Application.Features.Brands.Queries.GetById;
using TestSite1.Domain.Entities.Catalog;

namespace TestSite1.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}