using TestSite1.Application.Interfaces.Common;

namespace TestSite1.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}