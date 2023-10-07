using MitoCodeApiRest.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// un simple cambio

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapGet("api/Personas", () => Results.Ok(new List<Persona>()
{
    new() { Id = 1, Nombre = "Erick" },
    new() { Id = 2, Nombre = "Adam" },
    new() { Id = 3, Nombre = "Roxana" },
}));

app.MapControllers();

app.Run();
