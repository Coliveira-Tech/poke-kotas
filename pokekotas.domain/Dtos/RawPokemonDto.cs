using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("pokemon_v2_pokemonstats")]
        public List<RawPokemonStatsDto> PokemonStats { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemontypes")]
        public List<RawPokemonTypeDto> PokemonTypes { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemonsprites")]
        public List<RawPokemonSpriteDto> PokemonSprites { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemonspecy")]
        public RawPokemonSpeciesDto PokemonSpecies { get; set; } = null!;
    }
}
