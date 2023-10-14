using MitoCodeApiRest.Entidades;

namespace MitoCodeApiRest;

public interface IPersonaRepository
{
    Task<ICollection<Persona>> ListAsync();
}
