using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonSpeciesDto
    {
        [JsonPropertyName("pokemon_v2_evolutionchain")]
        public RawEvolutionChainDto EvolutionChain { get; set; } = null!;
    }
}
