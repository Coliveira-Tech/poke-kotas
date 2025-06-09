using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    public class PokemonResult
    {
        [JsonPropertyName("pokemon_v2_pokemons")]
        public List<PokemonV2Pokemon> PokemonV2Pokemons { get; set; }

        [JsonPropertyName("pokemon_v2_evolutionchain")]
        public PokemonV2Evolutionchain PokemonV2Evolutionchain { get; set; }
    }

    public class PokemonV2Evolutionchain
    {
        [JsonPropertyName("pokemon_v2_pokemonspecies")]
        public List<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; }
    }

    public class PokemonV2Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("pokemon_v2_pokemonstats")]
        public List<PokemonV2Pokemonstat> PokemonV2Pokemonstats { get; set; }

        [JsonPropertyName("pokemon_v2_pokemontypes")]
        public List<PokemonV2Pokemontype> PokemonV2Pokemontypes { get; set; }

        [JsonPropertyName("pokemon_v2_pokemonsprites")]
        public List<PokemonV2Pokemonsprite> PokemonV2Pokemonsprites { get; set; }
    }

    public class PokemonV2Pokemonspecy
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PokemonV2Pokemonsprite
    {
        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }
    }

    public class PokemonV2Pokemonstat
    {
        [JsonPropertyName("pokemon_v2_stat")]
        public PokemonV2Stat PokemonV2Stat { get; set; }

        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }

    public class PokemonV2Pokemontype
    {
        [JsonPropertyName("pokemon_v2_type")]
        public PokemonV2Type PokemonV2Type { get; set; }
    }

    public class PokemonV2Stat
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PokemonV2Type
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

    }

}
