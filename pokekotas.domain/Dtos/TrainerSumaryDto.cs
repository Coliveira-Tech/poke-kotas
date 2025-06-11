using Pokekotas.Domain.Entities;

namespace Pokekotas.Domain.Dtos
{
    public class TrainerSumaryDto(Trainer entity)
    {
        public Guid Id { get; set; } = entity.Id;
        public string Name { get; set; } = entity.Name;
        public int Age { get; set; } = entity.Age;
    }
}
