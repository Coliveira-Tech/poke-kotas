using FlurlGraphQL;
using Pokekotas.Domain.Dtos;

namespace Pokekotas.Api.Interfaces
{
    public interface IPokemonAcl
    {
        Task<IGraphQLQueryResults<RawPokemonDto>> GetById(int pokemonId);
        Task<IGraphQLQueryResults<RawPokemonDto>> GetRandom(int quantity);
    }
}
