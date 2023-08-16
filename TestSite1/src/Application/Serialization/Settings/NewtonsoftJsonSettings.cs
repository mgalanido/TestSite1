
using Newtonsoft.Json;
using TestSite1.Application.Interfaces.Serialization.Settings;

namespace TestSite1.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}