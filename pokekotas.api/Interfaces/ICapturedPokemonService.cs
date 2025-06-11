using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Interfaces
{
    public interface ICapturedPokemonService
    {
        Task<CapturedPokemonResponse> GetAll();
        Task<CapturedPokemonResponse> GetByTrainerId(Guid id);
        Task<CapturedPokemonResponse> Insert(CapturedPokemonInsertRequest request);
    }
}
