using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Responses.Audit;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}