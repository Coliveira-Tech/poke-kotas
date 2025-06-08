using Microsoft.AspNetCore.Mvc;
using Pokekotas.Api.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Pokekotas.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController(IPokemonAcl service) : Controller
    {
        private readonly IPokemonAcl _service = service;

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetRandom(10));
        }

    }
}
