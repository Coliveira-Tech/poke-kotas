namespace Pokekotas.Domain.Dtos
{
    public class PokemonStatsDto
    {
        public PokemonStatsDto() {}

        public PokemonStatsDto(List<RawPokemonStatsDto> pokemonStats)
        {
            if (pokemonStats == null || pokemonStats.Count == 0)
                throw new ArgumentException("Pokemon stats cannot be null or empty.", nameof(pokemonStats));

            foreach (var stats in pokemonStats)
            {
                switch (stats.Stats.Name.ToLower())
                {
                    case "hp":
                        Hp = stats.BaseStats;
                        break;
                    case "attack":
                        Attack = stats.BaseStats;
                        break;
                    case "defense":
                        Defense = stats.BaseStats;
                        break;
                    case "special-attack":
                        SpecialAttack = stats.BaseStats;
                        break;
                    case "special-defense":
                        SpecialDefense = stats.BaseStats;
                        break;
                    case "speed":
                        Speed = stats.BaseStats;
                        break;
                    default:
                        throw new ArgumentException($"Unknown stat type: {stats.Stats.Name}");
                }
            }
        }

        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
    }
}