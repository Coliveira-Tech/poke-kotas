using FlurlGraphQL;
using Pokekotas.Domain.Dtos;

namespace Pokekotas.Api.Interfaces
{
    public interface IPokemonAcl
    {
        Task<IGraphQLQueryResults<PokemonResult>> GetById(int pokemonId);
        Task<IGraphQLQueryResults<PokemonResult>> GetRandom(int quantity);
    }
}
