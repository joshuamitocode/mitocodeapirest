using Microsoft.EntityFrameworkCore;
using MitoCodeApiRest.Entidades;

namespace MitoCodeApiRest.Data;

public class MitoCodeDbContext : DbContext
{
    public MitoCodeDbContext(DbContextOptions<MitoCodeDbContext> options)
    :base(options)
    {
        
    }

    public DbSet<Persona> Personae { get; set; } = default!;
}