using System.Threading.Tasks;
using TestSite1.Application.Features.Dashboards.Queries.GetData;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}