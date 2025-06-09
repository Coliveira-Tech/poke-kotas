namespace Pokekotas.Domain.Dtos
{
    public class PokemonTypeDto
    {
        public PokemonTypeDto() { }
        public PokemonTypeDto(PokemonV2Pokemontype pokemonType)
        {
            if (pokemonType == null)
                throw new ArgumentNullException(nameof(pokemonType), "Pokemon type cannot be null.");

            Id = pokemonType.PokemonV2Type.Id;
            Name = pokemonType.PokemonV2Type.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
    }
}
