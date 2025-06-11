using FlurlGraphQL;
using Pokekotas.Api.Interfaces;
using Pokekotas.Domain.Dtos;

namespace Pokekotas.Api.Acls
{
    public class PokemonAcl(IConfiguration configuration): IPokemonAcl
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly string _baseUrl = configuration.GetValue<string>("BaseUrlApi") ?? "";

        public async Task<IGraphQLQueryResults<RawPokemonDto>> GetById(int pokemonId)
        {
            return await _baseUrl
                            .WithGraphQLQuery(@"
                                query ($pokemonId: Int!)
                                {
                                  RawPokemons: pokemon_v2_pokemon(
                                    where: {id: {_eq: $pokemonId}, is_default: {_eq: true}}
                                  ) {
                                    id
                                    name
                                    height
                                    weight
                                    base_experience
                                    is_default
                                    pokemon_v2_pokemonstats {
                                      pokemon_v2_stat {
                                        name
                                      }
                                      base_stat
                                    }
                                    pokemon_v2_pokemontypes {
                                      pokemon_v2_type {
                                        id
                                        name
                                      }
                                    }
                                    pokemon_v2_pokemonsprites {
                                      sprites
                                    }
                                    pokemon_v2_pokemonspecy {
                                      pokemon_v2_evolutionchain {
                                        pokemon_v2_pokemonspecies {
                                          id
                                          name
                                        }
                                      }
                                    }
                                  }
                                }
                             ")
                            .SetGraphQLVariables(new { pokemonId })
                            .PostGraphQLQueryAsync()
                            .ReceiveGraphQLQueryResults<RawPokemonDto>();
        }

        public async Task<IGraphQLQueryResults<RawPokemonDto>> GetRandom(int quantity)
        {
            int lastPokemonAvailable = _configuration.GetValue<int>("LastPokemonAvailable");

            if (string.IsNullOrEmpty(_baseUrl))
                throw new InvalidOperationException("Base URL is not configured in the application settings.");

            if (quantity < 1 || quantity > lastPokemonAvailable)
                throw new ArgumentOutOfRangeException(nameof(quantity), $"Quantity must be between 1 and {lastPokemonAvailable}.");

            var random = new Random(DateTime.Now.Millisecond);
            var ids = Enumerable.Range(1, lastPokemonAvailable)
                                .OrderBy(_ => random.Next())
                                .Take(quantity)
                                .ToArray();

            return await _baseUrl 
                            .WithGraphQLQuery(@"
                                query ($ids: [Int!])
                                {
                                  RawPokemons: pokemon_v2_pokemon(
                                    order_by: {id: asc}
                                    limit: 10
                                    where: {id: {_in: $ids}, is_default: {_eq: true}}
                                  ) {
                                    id
                                    name
                                    height
                                    weight
                                    base_experience
                                    is_default
                                    pokemon_v2_pokemonstats {
                                      pokemon_v2_stat {
                                        name
                                      }
                                      base_stat
                                    }
                                    pokemon_v2_pokemontypes {
                                      pokemon_v2_type {
                                        id
                                        name
                                      }
                                    }
                                    pokemon_v2_pokemonsprites {
                                      sprites
                                    }
                                    pokemon_v2_pokemonspecy {
                                      pokemon_v2_evolutionchain {
                                        pokemon_v2_pokemonspecies {
                                          id
                                          name
                                        }
                                      }
                                    }
                                  }
                                }")
                            .SetGraphQLVariables(new { ids })
                            .PostGraphQLQueryAsync()
                            .ReceiveGraphQLQueryResults<RawPokemonDto>("RawPokemons");
        }
    }
}