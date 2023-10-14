using Microsoft.EntityFrameworkCore;
using MitoCodeApiRest.Data;
using MitoCodeApiRest.Entidades;

namespace MitoCodeApiRest;

public class PersonaRepository : IPersonaRepository
{
    private readonly MitoCodeDbContext _context;

    public PersonaRepository(MitoCodeDbContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Persona>> ListAsync()
    {
        return await _context.Set<Persona>()
            .AsNoTracking()
            .ToListAsync();
    }
}
