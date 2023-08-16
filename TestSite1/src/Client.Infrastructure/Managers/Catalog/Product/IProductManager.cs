using System.Threading.Tasks;
using TestSite1.Application.Features.Products.Commands.AddEdit;
using TestSite1.Application.Features.Products.Queries.GetAllPaged;
using TestSite1.Application.Requests.Catalog;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}