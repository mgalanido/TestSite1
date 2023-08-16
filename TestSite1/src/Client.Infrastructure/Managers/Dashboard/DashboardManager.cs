using System.Net.Http;
using System.Threading.Tasks;
using TestSite1.Application.Features.Dashboards.Queries.GetData;
using TestSite1.Client.Infrastructure.Extensions;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}