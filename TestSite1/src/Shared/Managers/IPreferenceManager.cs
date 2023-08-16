using System.Threading.Tasks;
using TestSite1.Shared.Settings;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}