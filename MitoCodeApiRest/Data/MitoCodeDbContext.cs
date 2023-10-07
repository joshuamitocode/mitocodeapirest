using Microsoft.EntityFrameworkCore;
using MitoCodeApiRest.Entidades;

namespace MitoCodeApiRest.Data;

public class MitoCodeDbContext : DbContext
{
    public MitoCodeDbContext(DbContextOptions<MitoCodeDbContext> options)
    :base(options)
    {
        
    }

    public DbSet<Persona> Personas { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Persona>()
            .HasData(new List<Persona>()
            {
                new() { Id = 1, Nombre = "Erick" },
                new() { Id = 2, Nombre = "Adam" },
                new() { Id = 3, Nombre = "Roxana" },
            });
    }
}