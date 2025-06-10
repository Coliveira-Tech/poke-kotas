using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonSpeciesIdNameDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }
}
