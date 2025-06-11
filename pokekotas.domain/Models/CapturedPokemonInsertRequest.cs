namespace Pokekotas.Domain.Models
{
    public class CapturedPokemonInsertRequest
    {
        public Guid TrainerId { get; set; }
        public int PokemonId { get; set; }
        public int Level { get; set; } = 1;
        public string? Nickname { get; set; }
    }
}
