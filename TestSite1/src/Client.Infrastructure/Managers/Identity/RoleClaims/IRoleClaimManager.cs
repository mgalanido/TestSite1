using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Requests.Identity;
using TestSite1.Application.Responses.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}