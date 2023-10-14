using Microsoft.EntityFrameworkCore;
using MitoCodeApiRest;
using MitoCodeApiRest.Data;
using MitoCodeApiRest.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// un simple cambio
builder.Services.AddDbContext<MitoCodeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MitoCodeConexion"));
});

builder.Services.AddTransient<IPersonaRepository, PersonaRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapGet("api/Personas", async (IPersonaRepository repository) =>
{
    var personas = await repository.ListAsync();
    
    return Results.Ok(new
    {
        Data = personas,
        Success = true
    });
});

app.MapControllers();

app.Run();
