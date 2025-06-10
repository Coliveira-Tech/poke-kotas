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

            if (result.Errors?.Count > 0)
            {
                _logger.LogError("Error fetching Pokemon by ID {PokemonId}: {Errors}", pokemonId, result.Errors);
                response.Message.AddRange(result.Errors.Select(e => e.Message));
            }

            if(result.Count == 0)
            {
                _logger.LogWarning("No Pokemon found with ID: {PokemonId}", pokemonId);
                response.Message.Add($"Pokemon with ID {pokemonId} not found.");
                response.ErrorCode = 404;
            }

            response.ListResponse = result
                                      .Select(x => new PokemonDto(x))
                                      .ToList();

            return response;
        }
    }
}
