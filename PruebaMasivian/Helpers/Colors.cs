using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
namespace PruebaMasivian.Helpers
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Colors
    {
        Red,
        Black
    }
}
