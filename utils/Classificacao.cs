using System.Text.Json.Serialization;

namespace ToolkitSigma
{
    class JsonTemplate
    {
        [JsonPropertyName("texto")]
        public string Texto { get; set; } = string.Empty;
        [JsonPropertyName("correto")]
        public char Correto { get; set; } = '?';
    }
}