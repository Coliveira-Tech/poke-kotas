using FlurlGraphQL;
using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;
using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Services
{
    public class PokemonService(ILogger<PokemonService> logger
                               , IPokemonAcl pokemonAcl) : IPokemonService
    {
        private readonly ILogger<PokemonService> _logger = logger;
        private readonly IPokemonAcl _pokemonAcl = pokemonAcl;

        public async Task<PokemonResponse> GetById(int pokemonId)
        {
            PokemonResponse response = new();
           
            try
            {
                _logger.LogInformation("Fetching Pokemon by ID: {PokemonId}", pokemonId);
                IGraphQLQueryResults<RawPokemonDto> result = await _pokemonAcl.GetById(pokemonId);

                if (result.HasAnyErrors())
                    response.Message = [.. result.Errors.Select(e => e.Message)];

                if (result.Count == 0)
                {
                    response.Message.Add($"Pokemon with ID {pokemonId} not found.");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                }

                response.ListResponse = [.. result.Select(pokemon => new PokemonDto(pokemon))];
            }
            catch (Exception ex)
            {
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<PokemonResponse> GetRandom(int quantity)
        {
            PokemonResponse response = new();

            try
            {
                _logger.LogInformation("Fetching {quantity} random pokemons", quantity);
                IGraphQLQueryResults<RawPokemonDto> result = await _pokemonAcl.GetRandom(quantity);

                if(result.HasAnyErrors())
                    response.Message = [.. result.Errors.Select(e => e.Message)];

                response.ListResponse = [.. result.Select(pokemon => new PokemonDto(pokemon))];
            }
            catch (Exception ex)
            {
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }
            
            return response;
        }
    }
}