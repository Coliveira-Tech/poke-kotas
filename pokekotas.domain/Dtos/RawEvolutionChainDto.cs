using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawEvolutionChainDto
    {
        [JsonPropertyName("pokemon_v2_pokemonspecies")]
        public List<RawPokemonSpeciesIdNameDto> PokemonSpeciesIdName { get; set; } = [];
    }
}
