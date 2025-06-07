using Pokekotas.Domain.Entities;

namespace Pokekotas.Api.Interfaces
{
    public interface ICapturedPokemonService
    {
        Task<IEnumerable<CapturedPokemon>> GetCapturedPokemons();
        Task<CapturedPokemon> GetCapturedPokemonById(Guid id);
        Task AddCapturedPokemon(CapturedPokemon capturedPokemon);
        Task UpdateCapturedPokemon(CapturedPokemon capturedPokemon);
        Task DeleteCapturedPokemon(Guid id);
    }
}
