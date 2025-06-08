using System.Text.Json.Serialization;

namespace Pokekotas.Domain.Dtos
{
    //tudo aqui é temporario
    public class Animated
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class BlackWhite
    {
        [JsonPropertyName("animated")]
        public Animated Animated { get; set; }

        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Crystal
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }

        [JsonPropertyName("back_shiny_transparent")]
        public string BackShinyTransparent { get; set; }

        [JsonPropertyName("front_shiny_transparent")]
        public string FrontShinyTransparent { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("pokemon")]
        public List<Pokemon> Pokemon { get; set; }
    }

    public class DiamondPearl
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class DreamWorld
    {
        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class Emerald
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class FireredLeafgreen
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class GenerationI
    {
        [JsonPropertyName("yellow")]
        public Yellow Yellow { get; set; }

        [JsonPropertyName("red-blue")]
        public RedBlue RedBlue { get; set; }
    }

    public class GenerationIi
    {
        [JsonPropertyName("gold")]
        public Gold Gold { get; set; }

        [JsonPropertyName("silver")]
        public Silver Silver { get; set; }

        [JsonPropertyName("crystal")]
        public Crystal Crystal { get; set; }
    }

    public class GenerationIii
    {
        [JsonPropertyName("emerald")]
        public Emerald Emerald { get; set; }

        [JsonPropertyName("ruby-sapphire")]
        public RubySapphire RubySapphire { get; set; }

        [JsonPropertyName("firered-leafgreen")]
        public FireredLeafgreen FireredLeafgreen { get; set; }
    }

    public class GenerationIv
    {
        [JsonPropertyName("platinum")]
        public Platinum Platinum { get; set; }

        [JsonPropertyName("diamond-pearl")]
        public DiamondPearl DiamondPearl { get; set; }

        [JsonPropertyName("heartgold-soulsilver")]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
    }

    public class GenerationV
    {
        [JsonPropertyName("black-white")]
        public BlackWhite BlackWhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonPropertyName("x-y")]
        public XY XY { get; set; }

        [JsonPropertyName("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }
    }

    public class GenerationVii
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }

        [JsonPropertyName("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }

    public class GenerationViii
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }
    }

    public class Gold
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Home
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Icons
    {
        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Other
    {
        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("showdown")]
        public Showdown Showdown { get; set; }

        [JsonPropertyName("dream_world")]
        public DreamWorld DreamWorld { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }

    public class Platinum
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

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

    public class RedBlue
    {
        [JsonPropertyName("back_gray")]
        public string BackGray { get; set; }

        [JsonPropertyName("front_gray")]
        public string FrontGray { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class RubySapphire
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class Showdown
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Silver
    {
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("other")]
        public Other Other { get; set; }

        [JsonPropertyName("versions")]
        public Versions Versions { get; set; }

        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Versions
    {
        [JsonPropertyName("generation-i")]
        public GenerationI GenerationI { get; set; }

        [JsonPropertyName("generation-v")]
        public GenerationV GenerationV { get; set; }

        [JsonPropertyName("generation-ii")]
        public GenerationIi GenerationIi { get; set; }

        [JsonPropertyName("generation-iv")]
        public GenerationIv GenerationIv { get; set; }

        [JsonPropertyName("generation-vi")]
        public GenerationVi GenerationVi { get; set; }

        [JsonPropertyName("generation-iii")]
        public GenerationIii GenerationIii { get; set; }

        [JsonPropertyName("generation-vii")]
        public GenerationVii GenerationVii { get; set; }

        [JsonPropertyName("generation-viii")]
        public GenerationViii GenerationViii { get; set; }
    }

    public class XY
    {
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Yellow
    {
        [JsonPropertyName("back_gray")]
        public string BackGray { get; set; }

        [JsonPropertyName("front_gray")]
        public string FrontGray { get; set; }

        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }
}
