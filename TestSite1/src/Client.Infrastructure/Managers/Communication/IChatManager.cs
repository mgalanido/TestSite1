using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Interfaces.Chat;
using TestSite1.Application.Models.Chat;
using TestSite1.Application.Responses.Identity;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}