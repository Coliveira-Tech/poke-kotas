using Pokekotas.Domain.Entities;
using Pokekotas.Domain.Models;

namespace Pokekotas.Api.Interfaces
{
    public interface ITrainerService
    {
        Task<TrainerResponse> Delete(Guid id);
        Task<TrainerResponse> GetAll();
        Task<TrainerResponse> GetById(Guid id);
        Task<TrainerResponse> Insert(TrainerInsertRequest request);
        Task<TrainerResponse> Update(Guid id, TrainerUpdateRequest request);
    }
}
