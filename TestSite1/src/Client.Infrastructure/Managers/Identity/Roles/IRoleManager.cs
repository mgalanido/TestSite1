using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Requests.Identity;
using TestSite1.Application.Responses.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Identity.Roles
{
    public interface IRoleManager : IManager
    {
        Task<IResult<List<RoleResponse>>> GetRolesAsync();

        Task<IResult<string>> SaveAsync(RoleRequest role);

        Task<IResult<string>> DeleteAsync(string id);

        Task<IResult<PermissionResponse>> GetPermissionsAsync(string roleId);

        Task<IResult<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}