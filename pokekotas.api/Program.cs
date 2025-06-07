using Microsoft.EntityFrameworkCore;
using Pokekotas.Api.Extensions;
using Pokekotas.Api.Infra.Data;
using Pokekotas.Api.Interfaces;
using Pokekotas.Api.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ITrainerService, TrainerService>();

builder.Services.AddMvc()
                .AddJsonOptions(x =>
                {
                    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                    x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                });

string? conn = builder.Configuration.GetConnectionString("PokekotasDatabase");
builder.Services.AddDbContext<Context>(options => options.UseSqlite(conn));
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/health");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Swagger"));
    app.ApplyMigrations();
}

bool isInContainer = builder.Configuration.GetValue("DOTNET_RUNNING_IN_CONTAINER", false);

if (!isInContainer)
    app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();
