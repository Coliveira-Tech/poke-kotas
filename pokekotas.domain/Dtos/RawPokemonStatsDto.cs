using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonStatsDto
    {
        [JsonPropertyName("pokemon_v2_stat")]
        public RawStatsDto Stats { get; set; } = null!;

        [JsonPropertyName("base_stat")]
        public int BaseStats { get; set; }
    }
}
