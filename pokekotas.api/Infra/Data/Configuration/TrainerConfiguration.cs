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
            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.HasKey(e => e.Id);
        }
    }
}