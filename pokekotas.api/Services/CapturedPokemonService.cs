using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Entities;

namespace Pokekotas.Api.Services
{
    public class CapturedPokemonService(ILogger<CapturedPokemonService> logger,
                      IRepository<CapturedPokemon> repository): ICapturedPokemonService
    {
        public async Task<IEnumerable<CapturedPokemon>> GetCapturedPokemons()
        {
            logger.LogInformation("Fetching all captured pokemons from the repository.");
            return await repository.GetAll();
        }
        public async Task<CapturedPokemon> GetCapturedPokemonById(Guid id)
        {
            logger.LogInformation($"Fetching captured pokemon with ID {id} from the repository.");
            var capturedPokemons = await repository.Get(p => p.Id == id);
            return capturedPokemons.FirstOrDefault(new CapturedPokemon());
        }
        public async Task AddCapturedPokemon(CapturedPokemon capturedPokemon)
        {
            logger.LogInformation("Adding a new captured pokemon to the repository.");
            await repository.Insert(capturedPokemon);
        }
        public async Task UpdateCapturedPokemon(CapturedPokemon capturedPokemon)
        {
            logger.LogInformation($"Updating captured pokemon with ID {capturedPokemon.Id} in the repository.");
            await repository.Update(capturedPokemon);
        }
        public async Task DeleteCapturedPokemon(Guid id)
        {
            logger.LogInformation($"Deleting captured pokemon with ID {id} from the repository.");
            var capturedPokemon = await GetCapturedPokemonById(id);
            if (capturedPokemon != null)
            {
                await repository.Delete(capturedPokemon);
            }
        }
    }
}
