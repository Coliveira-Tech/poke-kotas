using Pokekotas.Domain.Entities;

namespace Pokekotas.Domain.Dtos
{
    public class CapturedPokemonDto : PokemonDto
    {
        public CapturedPokemonDto(CapturedPokemon entity
                                , RawPokemonDto rawPokemon
                                , bool includeTrainer = true) : base(rawPokemon)
        {
            PokemonId = entity.PokemonId;
            CapturedAt = entity.CapturedAt;
            Level = entity.Level;
            Nickname = entity.Nickname;
            
            if(includeTrainer)
                Trainer = new TrainerSumaryDto(entity.Trainer);
        }

        public int PokemonId { get; set; }
        public DateTime CapturedAt { get; set; } = DateTime.UtcNow;
        public int Level { get; set; } = 1;
        public string? Nickname { get; set; }
        public TrainerSumaryDto Trainer { get; set; } = null!;
    }
}
