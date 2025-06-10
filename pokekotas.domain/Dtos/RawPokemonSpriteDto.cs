using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonSpriteDto
    {
        [JsonPropertyName("sprites")]
        public RawSpritesDto Sprites { get; set; } = null!;
    }
}
