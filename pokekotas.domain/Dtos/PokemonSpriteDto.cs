namespace Pokekotas.Domain.Dtos
{
    public class PokemonSpriteDto
    {
        public PokemonSpriteDto() { }
        public PokemonSpriteDto(PokemonV2Pokemonsprite pokemonSprite)
        {
            if (pokemonSprite == null)
                throw new ArgumentNullException(nameof(pokemonSprite), "Pokemon sprite cannot be null.");

            FrontDefault = pokemonSprite.Sprites.FrontDefault;
            BackDefault = pokemonSprite.Sprites.BackDefault;
        }

        public string BackDefault { get; set; } = null!;
        public string FrontDefault { get; set; } = null!;
    }
}
