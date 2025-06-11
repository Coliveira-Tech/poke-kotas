namespace Pokekotas.Domain.Dtos
{
    public class PokemonSpriteDto
    {
        public PokemonSpriteDto(RawPokemonSpriteDto pokemonSprite)
        {
            if (pokemonSprite == null)
                throw new ArgumentNullException(nameof(pokemonSprite), "Pokemon sprite cannot be null.");

            FrontDefault = ConvertImageToBase64(pokemonSprite.Sprites.FrontDefault);
            BackDefault = ConvertImageToBase64(pokemonSprite.Sprites.BackDefault);
        }

        public string BackDefault { get; set; } = null!;
        public string FrontDefault { get; set; } = null!;

        static string ConvertImageToBase64(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return string.Empty;

            using HttpClient client = new();
            byte[] imageBytes = client.GetByteArrayAsync(imageUrl).Result;
            return Convert.ToBase64String(imageBytes);
        }
    }
}
