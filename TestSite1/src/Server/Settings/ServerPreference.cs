using System.Linq;
using TestSite1.Shared.Constants.Localization;
using TestSite1.Shared.Settings;

namespace TestSite1.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}