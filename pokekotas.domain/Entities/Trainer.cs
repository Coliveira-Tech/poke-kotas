namespace Pokekotas.Domain.Entities
{
    public class Trainer: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Document { get; set; } = string.Empty;
    }
}
