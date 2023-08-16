using TestSite1.Application.Requests;

namespace TestSite1.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}