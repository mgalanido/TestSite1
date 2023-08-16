using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Interfaces.Common;
using TestSite1.Application.Requests.Identity;
using TestSite1.Application.Responses.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}