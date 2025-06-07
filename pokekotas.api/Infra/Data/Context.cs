using Pokekotas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Pokekotas.Api.Infra.Data
{
    [ExcludeFromCodeCoverage]
    public class Context : DbContext
    {
        public Context(DbContextOptions options, int commandTimeout = 180) : base(options)
        {
            Database.SetCommandTimeout(commandTimeout);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Warning);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<CapturedPokemon> CapturedPokemons { get; set; }
    }
}
