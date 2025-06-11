using Pokekotas.Domain.Entities;

namespace Pokekotas.Domain.Dtos
{
    public class CapturedPokemonDto(CapturedPokemon entity, RawPokemonDto rawPokemon) : PokemonDto(rawPokemon)
    {
        public int PokemonId { get; set; } = entity.PokemonId;
        public DateTime CapturedAt { get; set; } = entity.CapturedAt;
        public int Level { get; set; } = entity.Level;
        public string? Nickname { get; set; } = entity.Nickname;
        public TrainerSumaryDto Trainer { get; set; } = new TrainerSumaryDto(entity.Trainer);
    }
}
