using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokekotas.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Pokekotas.Api.Infra.Data.Configuration
{
    [ExcludeFromCodeCoverage]
    public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.ToTable("Trainer");
            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Age).IsRequired();
            builder.Property(e => e.Document).IsRequired().HasMaxLength(20);

            builder.HasKey(e => e.Id);
            builder.Navigation(e => e.CapturedPokemons).AutoInclude();
        }
    }
}