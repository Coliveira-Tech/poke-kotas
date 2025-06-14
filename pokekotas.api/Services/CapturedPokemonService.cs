﻿using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;
using Pokekotas.Domain.Entities;
using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Services
{
    public class CapturedPokemonService(ILogger<CapturedPokemonService> logger
                                      , IRepository<CapturedPokemon> repository
                                      , IPokemonAcl pokemonAcl): ICapturedPokemonService
    {
        private readonly ILogger<CapturedPokemonService> _logger = logger;
        private readonly IRepository<CapturedPokemon> _repository = repository;
        private readonly IPokemonAcl _pokemonAcl = pokemonAcl;

        public async Task<CapturedPokemonResponse> GetAll()
        {
            CapturedPokemonResponse response = new();

            try
            {
                IEnumerable<CapturedPokemon> entities = await _repository.GetAll();

                if (!entities.Any())
                {
                    response.Message.Add("No captured pokemon found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return response;
                }

                await PopulatePokemonData(response, entities);

                _logger.LogInformation("Successfully retrieve {count} captured pokemons", entities.Count());
            }
            catch (Exception ex)
            {
                response.Message.Add("Error trying to retrieve captured pokemon");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<CapturedPokemonResponse> GetByTrainerId(Guid trainerId)
        {
            CapturedPokemonResponse response = new();

            try
            {
                IEnumerable<CapturedPokemon> entities = await _repository
                                                                .Get(x => x.TrainerId == trainerId);

                if (!entities.Any())
                {
                    response.Message.Add("No captured pokemon found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return response;
                }

                await PopulatePokemonData(response, entities);

                _logger.LogInformation("Successfully retrieve {count} captured pokemons", entities.Count());
            }
            catch (Exception ex)
            {
                response.Message.Add("Error trying to retrieve captured pokemon");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<CapturedPokemonResponse> Insert(CapturedPokemonInsertRequest request)
        {
            CapturedPokemonResponse response = new();

            try
            {
                CapturedPokemon entity = new()
                {
                    TrainerId = request.TrainerId,
                    PokemonId = request.PokemonId,
                    Level = request.Level,
                    Nickname = request.Nickname,
                };

                await _repository.Insert(entity);

                await PopulatePokemonData(response, [entity]);

                _logger.LogInformation("Successfully inserted captured pokemon {id}", entity.Id);
            }
            catch (Exception ex)
            {
                response.Message.Add($"Error trying to insert captured pokemon");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        private async Task PopulatePokemonData(CapturedPokemonResponse response, IEnumerable<CapturedPokemon> entities)
        {
            var rawPokemonResult = await _pokemonAcl.GetByIds([.. entities.Select(pokemon => pokemon.PokemonId)]);

            if (rawPokemonResult.HasAnyErrors())
            {
                response.Message = [.. rawPokemonResult.Errors.Select(e => e.Message)];
                response.ErrorCode = StatusCodes.Status400BadRequest;
                return;
            }

            rawPokemonResult.ToList().ForEach(rawPokemon =>
            {
                CapturedPokemon? entity = entities
                                            .FirstOrDefault(p => p.PokemonId == rawPokemon.Id);

                if (entity is null)
                {
                    response.Message.Add($"CapturedPokemon with PokemonId {rawPokemon.Id} not found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return;
                }

                CapturedPokemonDto capturedPokemon = new(entity, rawPokemon);

                response.ListResponse.Add(capturedPokemon);
            });
        }
    }
}
