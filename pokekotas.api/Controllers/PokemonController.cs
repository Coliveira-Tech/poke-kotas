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
    public class PokemonController(IPokemonService service) : Controller
    {
        private readonly IPokemonService _service = service;

        [HttpGet("{pokemonId:int}")]
        public async Task<IActionResult> GetById(int pokemonId)
        {
            PokemonResponse result = await _service.GetById(pokemonId);
            return result.ToHttpResult();
        }

        [HttpGet("get-random")]
        public async Task<IActionResult> GetRandom()
        {
            PokemonResponse result = await _service.GetRandom(10);
            return result.ToHttpResult();
        }
    }
}
