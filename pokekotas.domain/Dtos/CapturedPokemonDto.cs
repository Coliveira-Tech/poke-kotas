using Pokekotas.Domain.Entities;
using Pokekotas.Domain.Models;

namespace Pokekotas.Domain.Dtos
{
    public class CapturedPokemonDto : PokemonDto
    {
        //public CapturedPokemonDto() { }

        //public CapturedPokemonDto(CapturedPokemonInsertRequest request)
        //{
        //    TrainerId = request.TrainerId;
        //    PokemonId = request.PokemonId;
        //    Level = request.Level;
        //    Nickname = request.Nickname;
        //}

        //public CapturedPokemonDto(CapturedPokemon entity)
        //{
        //    TrainerId = entity.TrainerId;
        //    PokemonId = entity.PokemonId;
        //    CapturedAt = entity.CapturedAt;
        //    Level = entity.Level;
        //    Nickname = entity.Nickname;
        //}

        public CapturedPokemonDto(CapturedPokemon entity, RawPokemonDto rawPokemon): base(rawPokemon)
        {
            //TrainerId = entity.TrainerId;
            PokemonId = entity.PokemonId;
            CapturedAt = entity.CapturedAt;
            Level = entity.Level;
            Nickname = entity.Nickname;
            Trainer = new TrainerDto(entity.Trainer);
        }

        //public Guid TrainerId { get; set; }
        public int PokemonId { get; set; }
        public DateTime CapturedAt { get; set; } = DateTime.UtcNow;
        public int Level { get; set; } = 1;
        public string? Nickname { get; set; }
        public TrainerDto Trainer { get; set; } = null!;
    }
}
