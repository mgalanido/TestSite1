using System.Threading.Tasks;
using TestSite1.Application.Requests.Mail;

namespace TestSite1.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}