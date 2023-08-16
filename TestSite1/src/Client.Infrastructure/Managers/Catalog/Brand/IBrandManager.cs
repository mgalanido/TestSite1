using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Features.Brands.Commands.AddEdit;
using TestSite1.Application.Features.Brands.Queries.GetAll;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}