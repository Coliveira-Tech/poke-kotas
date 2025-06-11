using Microsoft.AspNetCore.Mvc;
using Pokekotas.Api.Extensions;
using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Models;
using System.Diagnostics.CodeAnalysis;

namespace Pokekotas.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController(ITrainerService trainerService
                                 , ICapturedPokemonService capturedPokemonService) : Controller
    {
        private readonly ITrainerService _trainerService = trainerService;
        private readonly ICapturedPokemonService _capturedPokemonService = capturedPokemonService;

        [HttpGet("{trainerId:Guid}")]
        public async Task<IActionResult> GetById(Guid trainerId)
        {
            TrainerResponse result = await _trainerService.GetById(trainerId);
            return result.ToHttpResult();
        }

        [HttpGet("{trainerId:Guid}/captured-pokemons")]
        public async Task<IActionResult> GetCapturedPokemons(Guid trainerId)
        {
            CapturedPokemonResponse result = await _capturedPokemonService
                                                        .GetByTrainerId(trainerId);
            return result.ToHttpResult();
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            TrainerResponse result = await _trainerService.GetAll();
            return result.ToHttpResult();
        }

        [HttpPost()]
        public async Task<IActionResult> Insert([FromBody] TrainerInsertRequest request)
        {
            TrainerResponse result = await _trainerService.Insert(request);
            return result.ToHttpResult();
        }

        [HttpPost("{trainerId:Guid}/captured-pokemons")]
        public async Task<IActionResult> InsertCapturedPokemon(Guid trainerId, [FromBody] CapturedPokemonInsertRequest request)
        {
            CapturedPokemonResponse result = await _capturedPokemonService.Insert(request);
            return result.ToHttpResult();
        }

        [HttpPut("{trainerId:Guid}")]
        public async Task<IActionResult> Update(Guid trainerId, [FromBody] TrainerUpdateRequest request)
        {
            TrainerResponse result = await _trainerService.Update(trainerId, request);
            return result.ToHttpResult();
        }

        [HttpDelete("{trainerId:Guid}")]
        public async Task<IActionResult> Delete(Guid trainerId)
        {
            TrainerResponse result = await _trainerService.Delete(trainerId);
            return result.ToHttpResult();
        }
    }
}
