using System.Threading.Tasks;
using TestSite1.Application.Interfaces.Common;
using TestSite1.Application.Requests.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}