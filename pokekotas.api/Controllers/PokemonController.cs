using Microsoft.AspNetCore.Mvc;
using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;
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

            var result = await _service.GetRandom(10);

            List<PokemonDto> pokemonList = result.Select(x => new PokemonDto(x)).ToList();


            return Ok(pokemonList);
        }

    }
}
