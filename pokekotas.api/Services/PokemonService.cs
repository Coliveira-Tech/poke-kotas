using FlurlGraphQL;
using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;
using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Services
{
    public class PokemonService(Logger<PokemonService> logger
                               , IPokemonAcl pokemonAcl) : IPokemonService
    {
        private readonly Logger<PokemonService> _logger = logger;
        private readonly IPokemonAcl _pokemonAcl = pokemonAcl;

        public async Task<PokemonResponse> GetById(int pokemonId)
        {
            PokemonResponse response = new();

            _logger.LogInformation("Fetching Pokemon by ID: {PokemonId}", pokemonId);
            IGraphQLQueryResults<RawPokemonDto> result = await _pokemonAcl.GetById(pokemonId);

            response.Message = [.. result.Errors.Select(e => e.Message)];

            if (result.Count == 0)
            {
                response.Message.Add($"Pokemon with ID {pokemonId} not found.");
                response.ErrorCode = 404;
            }

            response.ListResponse = [.. result.Select(pokemon => new PokemonDto(pokemon))];

            return response;
        }

        public async Task<PokemonResponse> GetRandom(int quantity)
        {
            PokemonResponse response = new();

            _logger.LogInformation("Fetching {quantity} random pokemons", quantity);
            IGraphQLQueryResults<RawPokemonDto> result = await _pokemonAcl.GetRandom(quantity);

            response.Message = [.. result.Errors.Select(e => e.Message)];
            response.ListResponse = [.. result.Select(pokemon => new PokemonDto(pokemon))];

            return response;
        }
    }
}
