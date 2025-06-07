using Pokekotas.Api.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Pokekotas.Api.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using Context dbContext =
                scope.ServiceProvider.GetRequiredService<Context>();

            dbContext.Database.Migrate();
        }
    }
}
