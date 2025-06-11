namespace Pokekotas.Domain.Dtos
{
    public class EvolutionChainDto
    {
        public EvolutionChainDto(RawPokemonSpeciesIdNameDto evolutionChain)
        {
            if (evolutionChain == null)
                throw new ArgumentNullException(nameof(evolutionChain), "Evolution chain cannot be null.");

            Id = evolutionChain.Id;
            Name = evolutionChain.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
