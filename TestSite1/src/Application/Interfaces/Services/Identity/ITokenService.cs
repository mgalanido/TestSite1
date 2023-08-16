using System.Threading.Tasks;
using TestSite1.Application.Interfaces.Common;
using TestSite1.Application.Requests.Identity;
using TestSite1.Application.Responses.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}