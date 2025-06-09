using FlurlGraphQL;
using Pokekotas.Domain.Dtos;

namespace Pokekotas.Api.Interfaces
{
    public interface IPokemonAcl
    {
        Task<IGraphQLQueryResults<RawPokemonResultDto>> GetById(int pokemonId);
        Task<IGraphQLQueryResults<RawPokemonResultDto>> GetRandom(int quantity);
    }
}
