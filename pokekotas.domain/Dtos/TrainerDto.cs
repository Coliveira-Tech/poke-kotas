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
        }

        public TrainerDto(Trainer entity, List<RawPokemonDto> RawPokemonList)
        {
            Id = entity.Id;
            Name = entity.Name;
            Age = entity.Age;
            Document = entity.Document;

            RawPokemonList.ForEach(rawPokemon =>
            {
                CapturedPokemon? capturedPokemon = entity
                                                    .CapturedPokemons
                                                    .FirstOrDefault(p => p.PokemonId == rawPokemon.Id);
                if (capturedPokemon is not null)
                    CapturedPokemons.Add(new CapturedPokemonDto(capturedPokemon, rawPokemon));
            });
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Document { get; set; } = string.Empty;
        public List<CapturedPokemonDto> CapturedPokemons { get; set; } = [];
    }
}
