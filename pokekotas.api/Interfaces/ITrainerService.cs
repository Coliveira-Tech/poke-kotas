using Pokekotas.Domain.Entities;

namespace Pokekotas.Api.Interfaces
{
    public interface ITrainerService
    {
        Task<IEnumerable<Trainer>> GetTrainers();
        Task<Trainer> GetTrainerById(Guid id);
        Task AddTrainer(Trainer trainer);
        Task UpdateTrainer(Trainer trainer);
        Task DeleteTrainer(Guid id);
    }
}
