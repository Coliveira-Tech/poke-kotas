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
    public class TrainerController(ITrainerService service) : Controller
    {
        private readonly ITrainerService _service = service;

        [HttpGet("{trainerId:Guid}")]
        public async Task<IActionResult> GetById(Guid trainerId)
        {
            TrainerResponse result = await _service.GetById(trainerId);
            return result.ToHttpResult();
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            TrainerResponse result = await _service.GetAll();
            return result.ToHttpResult();
        }

        [HttpPost()]
        public async Task<IActionResult> Insert([FromBody] TrainerInsertRequest request)
        {
            TrainerResponse result = await _service.Insert(request);
            return result.ToHttpResult();
        }

        [HttpPut("{trainerId:Guid}")]
        public async Task<IActionResult> Update(Guid trainerId, [FromBody] TrainerUpdateRequest request)
        {
            TrainerResponse result = await _service.Update(trainerId, request);
            return result.ToHttpResult();
        }

        [HttpDelete("{trainerId:Guid}")]
        public async Task<IActionResult> Delete(Guid trainerId)
        {
            TrainerResponse result = await _service.Delete(trainerId);
            return result.ToHttpResult();
        }
    }
}
