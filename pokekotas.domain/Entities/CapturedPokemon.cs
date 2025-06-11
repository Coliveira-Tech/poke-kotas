namespace Pokekotas.Domain.Entities
{
    public class CapturedPokemon : BaseEntity
    {
        public int PokemonId { get; set; }
        public DateTime CapturedAt { get; set; } = DateTime.UtcNow;
        public int Level { get; set; } = 1;
        public string? Nickname { get; set; }
        public Guid TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; } = null!;
    }
}
