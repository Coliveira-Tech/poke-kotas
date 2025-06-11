namespace Pokekotas.Domain.Dtos
{
    public class PokemonDto
    {
        public PokemonDto(RawPokemonDto pokemon)
        {
            if (pokemon == null)
                throw new ArgumentNullException(nameof(pokemon), "Pokemon cannot be null.");

            Id = pokemon.Id;
            Name = pokemon.Name;
            Height = pokemon.Height;
            Weight = pokemon.Weight;
            BaseExperience = pokemon.BaseExperience;
            IsDefault = pokemon.IsDefault;
            PokemonStats = new PokemonStatsDto(pokemon.PokemonStats);
            PokemonTypes = [.. pokemon.PokemonTypes
                                        .Select(type => new PokemonTypeDto(type))];
            PokemonSprites = [.. pokemon
                                .PokemonSprites
                                .Select(sprite => new PokemonSpriteDto(sprite))];
            EvolutionChain = [.. pokemon
                                .PokemonSpecies
                                .EvolutionChain
                                .PokemonSpeciesIdName
                                .Select(evolutions => new EvolutionChainDto(evolutions))];
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Height { get; set; }
        public int Weight { get; set; }
        public int BaseExperience { get; set; }
        public bool IsDefault { get; set; }
        public PokemonStatsDto PokemonStats { get; set; } = new();
        public List<PokemonTypeDto> PokemonTypes { get; set; } = [];
        public List<PokemonSpriteDto> PokemonSprites { get; set; } = [];
        public List<EvolutionChainDto> EvolutionChain { get; set; } = [];
    }
}
