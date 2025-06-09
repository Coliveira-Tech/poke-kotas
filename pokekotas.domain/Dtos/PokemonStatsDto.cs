namespace Pokekotas.Domain.Dtos
{
    public class PokemonStatsDto
    {
        public PokemonStatsDto() {}

        public PokemonStatsDto(List<RawPokemonstatDto> pokemonStats)
        {
            if (pokemonStats == null || pokemonStats.Count == 0)
                throw new ArgumentException("Pokemon stats cannot be null or empty.", nameof(pokemonStats));

            foreach (var stat in pokemonStats)
            {
                switch (stat.PokemonV2Stat.Name.ToLower())
                {
                    case "hp":
                        Hp = stat.BaseStat;
                        break;
                    case "attack":
                        Attack = stat.BaseStat;
                        break;
                    case "defense":
                        Defense = stat.BaseStat;
                        break;
                    case "special-attack":
                        SpecialAttack = stat.BaseStat;
                        break;
                    case "special-defense":
                        SpecialDefense = stat.BaseStat;
                        break;
                    case "speed":
                        Speed = stat.BaseStat;
                        break;
                    default:
                        throw new ArgumentException($"Unknown stat type: {stat.PokemonV2Stat.Name}");
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