namespace Pokekotas.Domain.Dtos
{
    public class PokemonTypeDto
    {
        public PokemonTypeDto() { }
        public PokemonTypeDto(RawPokemonTypeDto pokemonType)
        {
            if (pokemonType == null)
                throw new ArgumentNullException(nameof(pokemonType), "Pokemon type cannot be null.");

            Id = pokemonType.Type.Id;
            Name = pokemonType.Type.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
    }
}
