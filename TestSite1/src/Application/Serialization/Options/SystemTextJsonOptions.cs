using System.Text.Json;
using TestSite1.Application.Interfaces.Serialization.Options;

namespace TestSite1.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}