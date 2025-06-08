using FlurlGraphQL;
using Pokekotas.Domain.Dtos;

namespace Pokekotas.Api.Interfaces
{
    public interface IPokemonAcl
    {
        Task<IGraphQLQueryResults<Pokemon>> GetById(int pokemonId);
        Task<IGraphQLQueryResults<Pokemon>> GetRandom(int quantity);
    }
}
