using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MitoCodeApiRest.Entidades;

[Table(nameof(Persona))]
public class Persona
{
    public int Id { get; set; }
    [StringLength(100)]
    public string Nombre { get; set; } = default!;
}