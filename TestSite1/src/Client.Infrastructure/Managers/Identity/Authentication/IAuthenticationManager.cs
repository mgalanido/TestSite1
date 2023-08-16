using System.Security.Claims;
using System.Threading.Tasks;
using TestSite1.Application.Requests.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Identity.Authentication
{
    public interface IAuthenticationManager : IManager
    {
        Task<IResult> Login(TokenRequest model);

        Task<IResult> Logout();

        Task<string> RefreshToken();

        Task<string> TryRefreshToken();

        Task<string> TryForceRefreshToken();

        Task<ClaimsPrincipal> CurrentUser();
    }
}