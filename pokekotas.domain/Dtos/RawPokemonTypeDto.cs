using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonTypeDto
    {
        [JsonPropertyName("pokemon_v2_type")]
        public RawTypeDto Type { get; set; } = null!;
    }
}
