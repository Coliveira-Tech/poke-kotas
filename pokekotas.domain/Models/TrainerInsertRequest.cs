namespace Pokekotas.Domain.Models
{
    public class TrainerInsertRequest
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Document { get; set; } = string.Empty;
    }
}
