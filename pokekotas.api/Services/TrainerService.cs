using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;
using Pokekotas.Domain.Entities;
using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Services
{
    public class TrainerService(ILogger<TrainerService> logger
                              , IRepository<Trainer> repository
                              , IPokemonAcl pokemonAcl) : ITrainerService
    {
        private readonly ILogger<TrainerService> _logger = logger;
        private readonly IRepository<Trainer> _repository = repository;
        private readonly IPokemonAcl _pokemonAcl = pokemonAcl;

        public async Task<TrainerResponse> Delete(Guid id)
        {
            TrainerResponse response = new();
            try
            {
                Trainer? entity = (await _repository
                                            .Get(x => x.Id == id))
                                            .FirstOrDefault();

                if (entity == null)
                {
                    response.Message.Add("Trainer not found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return response;
                }

                await _repository.Delete(entity);

                response.ListResponse.Add(new TrainerDto(entity, await GetRawPokemonList(entity)));

                _logger.LogInformation("Successfully delete trainer {id}", entity.Id);
            }
            catch (Exception ex)
            {
                response.Message.Add($"Error trying to delete trainer {id}");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<TrainerResponse> GetAll()
        {
            TrainerResponse response = new();

            try
            {
                IEnumerable<Trainer> entities = await _repository.GetAll();

                if (!entities.Any())
                {
                    response.Message.Add("No trainer found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return response;
                }

                entities.ToList().ForEach(entity =>
                {
                    response.ListResponse.Add(new TrainerDto(entity, GetRawPokemonList(entity).Result));
                });

                _logger.LogInformation("Successfully retrieve {count} trainers", entities.Count());
            }
            catch (Exception ex)
            {
                response.Message.Add("Error trying to retrieve trainers");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<TrainerResponse> GetById(Guid id)
        {
            TrainerResponse response = new();

            try
            {
                Trainer? entity = (await _repository
                                            .Get(x => x.Id == id))
                                            .FirstOrDefault();

                if (entity == null)
                {
                    response.Message.Add("Trainer not found");
                    response.ErrorCode = StatusCodes.Status404NotFound;
                    return response;
                }

                response.ListResponse.Add(new TrainerDto(entity, await GetRawPokemonList(entity)));

                _logger.LogInformation("Successfully retrieve trainer {id}", entity.Id);
            }
            catch (Exception ex)
            {
                response.Message.Add($"Error trying to retrieve trainer {id}");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<TrainerResponse> Insert(TrainerInsertRequest request)
        {
            TrainerResponse response = new();

            try
            {
                Trainer entity = new()
                {
                    Name = request.Name,
                    Age = request.Age,
                    Document = request.Document
                };

                await _repository.Insert(entity);

                response.ListResponse.Add(new TrainerDto(entity, await GetRawPokemonList(entity)));

                _logger.LogInformation("Successfully inserted trainer {id}", entity.Id);
            }
            catch (Exception ex)
            {
                response.Message.Add($"Error trying to insert trainer");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        public async Task<TrainerResponse> Update(Guid id, TrainerUpdateRequest request)
        {
            TrainerResponse response = new();

            try
            {
                Trainer? entity = (await _repository
                                            .Get(x => x.Id == id))
                                            .FirstOrDefault();

                ArgumentNullException.ThrowIfNull(entity);

                entity.Name = request.Name;
                entity.Age = request.Age;
                entity.Document = request.Document;
                
                await _repository.Update(entity);

                response.ListResponse.Add(new TrainerDto(entity, await GetRawPokemonList(entity)));

                _logger.LogInformation("Trainer {id} successfully updated", entity.Id);
            }
            catch (Exception ex)
            {
                response.Message.Add($"Error trying to update trainer {id}");
                response.Message.Add(ex.Message);
                response.ErrorCode = StatusCodes.Status400BadRequest;
            }

            return response;
        }

        private async Task<List<RawPokemonDto>> GetRawPokemonList(Trainer entity)
        {
            var rawPokemonResult = await _pokemonAcl
                                       .GetByIds([.. entity.CapturedPokemons
                                                            .Select(pokemon => pokemon.PokemonId)]);

            if (rawPokemonResult.HasAnyErrors())
                throw new InvalidOperationException($"Error fetching Pokemon data: {string.Join("| ", rawPokemonResult.Errors.Select(e => e.Message))}");

            return [.. rawPokemonResult];
        }
    }
}
