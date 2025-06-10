using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawStatsDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }
}
