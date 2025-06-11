namespace Pokekotas.Domain.Models
{
    public class CapturedPokemonUpdateRequest
    {
        public Guid TrainerId { get; set; }
        public int Level { get; set; }
        public string? Nickname { get; set; }
    }
}
