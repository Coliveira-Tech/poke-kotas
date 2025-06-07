using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Entities;

namespace Pokekotas.Api.Services
{
    public class TrainerService(ILogger<TrainerService> logger,
                          IRepository<Trainer> repository): ITrainerService
    {
        public async Task<IEnumerable<Trainer>> GetTrainers()
        {
            logger.LogInformation("Fetching all trainers from the repository.");
            return await repository.GetAll();
        }
        public async Task<Trainer> GetTrainerById(Guid id)
        {
            logger.LogInformation($"Fetching trainer with ID {id} from the repository.");
            var trainers = await repository.Get(t => t.Id == id);
            return trainers.FirstOrDefault(new Trainer());
        }
        public async Task AddTrainer(Trainer trainer)
        {
            logger.LogInformation("Adding a new trainer to the repository.");
            await repository.Insert(trainer);
        }
        public async Task UpdateTrainer(Trainer trainer)
        {
            logger.LogInformation($"Updating trainer with ID {trainer.Id} in the repository.");
            await repository.Update(trainer);
        }
        public async Task DeleteTrainer(Guid id)
        {
            logger.LogInformation($"Deleting trainer with ID {id} from the repository.");
            var trainer = await GetTrainerById(id);
            if (trainer != null)
            {
                await repository.Delete(trainer);
            }
        }
    }
}
