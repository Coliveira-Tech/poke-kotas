using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Interfaces
{
    public interface IPokemonService
    {
        Task<PokemonResponse> GetById(int pokemonId);
        Task<PokemonResponse> GetRandom(int quantity);
    }
}
