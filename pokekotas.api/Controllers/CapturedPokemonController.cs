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
    public class CapturedPokemonController(ICapturedPokemonService service) : Controller
    {
        private readonly ICapturedPokemonService _service = service;

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            CapturedPokemonResponse result = await _service.GetAll();
            return result.ToHttpResult();
        }
    }
}
