using MudBlazor;
using System.Threading.Tasks;
using TestSite1.Shared.Managers;

namespace TestSite1.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}