﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokekotas.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Pokekotas.Api.Infra.Data.Configuration
{
    [ExcludeFromCodeCoverage]
    public class CapturedPokemonConfiguration : IEntityTypeConfiguration<CapturedPokemon>
    {
        public void Configure(EntityTypeBuilder<CapturedPokemon> builder)
        {
            builder.ToTable("CapturedPokemon");
            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.TrainerId).IsRequired();
            builder.Property(e => e.PokemonId).IsRequired();
            builder.Property(e => e.CapturedAt).IsRequired();
            builder.Property(e => e.Level)
                .IsRequired()
                .HasDefaultValue(1);
            builder.Property(e => e.Nickname);

            builder.HasKey(e => e.Id);

            builder.Navigation(e => e.Trainer).AutoInclude();

            builder.HasOne(e => e.Trainer)
                .WithMany(e => e.CapturedPokemons)
                .HasForeignKey(e => e.TrainerId)
                .IsRequired();
        }
    }
}