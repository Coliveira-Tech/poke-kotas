using Pokekotas.Domain.Entities;

namespace Pokekotas.Domain.Dtos
{
    public class TrainerSumaryDto
    {
        public TrainerSumaryDto(Trainer entity)
        {
            if(entity is null)
                return;

            Id = entity.Id;
            Name = entity.Name;
            Age = entity.Age;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
    }
}
