using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class RawPokemonResultDto
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
        public List<RawPokemonstatDto> PokemonV2Pokemonstats { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemontypes")]
        public List<RawPokemonTypeDto> PokemonV2Pokemontypes { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemonsprites")]
        public List<RawPokemonSpriteDto> PokemonV2Pokemonsprites { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemonspecy")]
        public RawPokemonSpeciesDto PokemonV2Pokemonspecy { get; set; } = null!;
    }

    public class RawEvolutionChainDto
    {
        [JsonPropertyName("pokemon_v2_pokemonspecies")]
        public List<RawPokemonSpeciesIdNameDto> PokemonV2Pokemonspecies { get; set; } = [];
    }

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
        public List<RawPokemonstatDto> PokemonV2Pokemonstats { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemontypes")]
        public List<RawPokemonTypeDto> PokemonV2Pokemontypes { get; set; } = [];

        [JsonPropertyName("pokemon_v2_pokemonsprites")]
        public List<RawPokemonSpriteDto> PokemonV2Pokemonsprites { get; set; } = [];
    }

    public class RawPokemonSpeciesDto
    {
        [JsonPropertyName("pokemon_v2_evolutionchain")]
        public RawEvolutionChainDto PokemonV2Evolutionchain { get; set; } = null!;
    }

    public class RawPokemonSpeciesIdNameDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class RawPokemonSpriteDto
    {
        [JsonPropertyName("sprites")]
        public RawSpritesDto Sprites { get; set; } = null!;
    }

    public class RawPokemonstatDto
    {
        [JsonPropertyName("pokemon_v2_stat")]
        public RawStatDto PokemonV2Stat { get; set; } = null!;

        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }

    public class RawPokemonTypeDto
    {
        [JsonPropertyName("pokemon_v2_type")]
        public RawTypeDto PokemonV2Type { get; set; } = null!;
    }

    public class RawStatDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class RawTypeDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class RawSpritesDto
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; } = null!;

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; } = null!;
    }
}
