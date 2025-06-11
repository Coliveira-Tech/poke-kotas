using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Interfaces
{
    public interface ICapturedPokemonService
    {
        //Task<CapturedPokemonResponse> Delete(Guid id);
        Task<CapturedPokemonResponse> GetAll();
        //Task<CapturedPokemonResponse> GetById(Guid id);
        Task<CapturedPokemonResponse> GetByTrainerId(Guid id);
        Task<CapturedPokemonResponse> Insert(CapturedPokemonInsertRequest request);
        //Task<CapturedPokemonResponse> Update(Guid id, CapturedPokemonUpdateRequest request);
    }
}
