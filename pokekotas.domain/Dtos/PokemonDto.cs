namespace Pokekotas.Domain.Dtos
{
    public class PokemonDto
    {
        public PokemonDto() { }

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
            //PokemonStats = new PokemonStatsDto(pokemon.PokemonV2Pokemonstats);
            //PokemonTypes = [.. pokemon.PokemonV2Pokemontypes.Select(pt => new PokemonTypeDto(pt))];
            //PokemonSprites = [.. pokemon.PokemonV2Pokemonsprites.Select(ps => new PokemonSpriteDto(ps))];
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
    }
}
