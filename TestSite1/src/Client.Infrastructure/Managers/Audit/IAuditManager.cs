using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Responses.Audit;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<IResult<string>> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}