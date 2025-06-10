using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawSpritesDto
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; } = null!;

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; } = null!;
    }
}
