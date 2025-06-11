using Pokekotas.Domain.Entities;

namespace Pokekotas.Domain.Dtos
{
    public class TrainerDto
    {
        public TrainerDto() { }

        public TrainerDto(Trainer entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Age = entity.Age;
            Document = entity.Document;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Document { get; set; } = string.Empty;
    }
}
